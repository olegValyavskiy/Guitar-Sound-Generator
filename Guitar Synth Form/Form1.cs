using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;

namespace GuitarSoundGenerator
{
    public partial class Form1 : Form
    {
        // Внутренние переменные для расчетов
        private int sampleRate = 44100;
        private int bitsPerSample = 16;
        private int channels = 1;
        private int duration = 2; // seconds
        private int maxFret = 12;
        private double attackTime = 0.12; // 60 ms for attack
        private double releaseTime = 2.0; // seconds
        private double sustainLevel = 0.5;
        private double sustainTime;

        // Критические параметры для вычислений
        private double attackExponent = -10; // Экспонента для атаки
        private double releaseConstant = 1.4; // Константа для релиза
        private double attackFrequency = 1500.0; // Частота атаки
        private double attackDecay = -8; // Экспонента затухания атаки
        private double inharmonicityFactor = 0.001; // Коэффициент негармоничности

        // Частоты открытых струн (струны 5 до 0)
        private double[] openFrequencies = new double[]
        {
            82.41,  // E2 - string 5
            110.00, // A2 - string 4
            146.82, // D3 - string 3
            196.00, // G3 - string 2
            246.94, // H3 - string 1
            329.63  // E4 - string 0
        };

        // Путь к последнему сгенерированному файлу
        private string lastGeneratedFile;

        public Form1()
        {
            InitializeComponent();
            sustainTime = duration - attackTime - releaseTime;

            // Инициализация значений элементов управления
            numSampleRate.Value = sampleRate;
            numDuration.Value = duration;
            numAttackTime.Value = (decimal)attackTime;
            numReleaseTime.Value = (decimal)releaseTime;
            numSustainLevel.Value = (decimal)sustainLevel;
            numAttackExponent.Value = (decimal)attackExponent;
            numReleaseConstant.Value = (decimal)releaseConstant;
            numAttackFrequency.Value = (decimal)attackFrequency;
            numAttackDecay.Value = (decimal)attackDecay;
            numInharmonicityFactor.Value = (decimal)inharmonicityFactor;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Обновляем внутренние переменные из элементов управления
            sampleRate = (int)numSampleRate.Value;
            duration = (int)numDuration.Value;
            attackTime = (double)numAttackTime.Value;
            releaseTime = (double)numReleaseTime.Value;
            sustainLevel = (double)numSustainLevel.Value;
            attackExponent = (double)numAttackExponent.Value;
            releaseConstant = (double)numReleaseConstant.Value;
            attackFrequency = (double)numAttackFrequency.Value;
            attackDecay = (double)numAttackDecay.Value;
            inharmonicityFactor = (double)numInharmonicityFactor.Value;
            sustainTime = duration - attackTime - releaseTime;

            // Создаем директорию, если она не существует
            string directory = "sounds";
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Генерация звуков для всех струн и ладов
            for (int stringNumber = 5; stringNumber >= 0; stringNumber--)
            {
                double openFrequency = openFrequencies[stringNumber];
                for (int fret = 0; fret <= maxFret; fret++)
                {
                    // Вычисляем частоту для текущего лада
                    double frequency = openFrequency * Math.Pow(2, fret / 12.0);

                    // Генерация звуковой волны
                    float[] samples = GenerateGuitarWaveform(frequency, duration, sampleRate, attackTime, sustainTime, releaseTime, sustainLevel, stringNumber);

                    // Конвертация в 16-битный PCM
                    short[] pcmSamples = new short[samples.Length];
                    for (int i = 0; i < samples.Length; i++)
                    {
                        pcmSamples[i] = (short)(samples[i] * short.MaxValue);
                    }

                    // Сохранение в файл
                    string filename = Path.Combine(directory, $"string{stringNumber}tone{fret}.wav");
                    using (WaveFileWriter writer = new WaveFileWriter(filename, new WaveFormat(sampleRate, bitsPerSample, channels)))
                    {
                        writer.WriteSamples(pcmSamples, 0, pcmSamples.Length);
                    }

                    // Сохраняем путь к последнему сгенерированному файлу
                    lastGeneratedFile = filename;

                    Console.WriteLine($"Generated {filename}");
                }
            }

            // Отрисовка графика для последнего сгенерированного звука
            float[] lastSamples = GenerateGuitarWaveform(openFrequencies[0] * Math.Pow(2, 0 / 12.0), duration, sampleRate, attackTime, sustainTime, releaseTime, sustainLevel, 0);
            DrawWaveform(lastSamples);

            MessageBox.Show("Все звуки сгенерированы!");
        }

        private void btnPlayLastSound_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lastGeneratedFile) && File.Exists(lastGeneratedFile))
            {
                PlaySound(lastGeneratedFile);
            }
            else
            {
                MessageBox.Show("Файл не найден. Сначала сгенерируйте звуки.");
            }
        }

        private void DrawWaveform(float[] samples)
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                Pen pen = new Pen(Color.Black);

                int midY = pictureBox.Height / 2;
                int samplesPerPixel = samples.Length / pictureBox.Width;

                for (int x = 0; x < pictureBox.Width; x++)
                {
                    float sum = 0;
                    for (int i = 0; i < samplesPerPixel; i++)
                    {
                        sum += samples[x * samplesPerPixel + i];
                    }
                    float avg = sum / samplesPerPixel;
                    int y = (int)(midY - avg * midY);
                    g.DrawLine(pen, x, midY, x, y);
                }
            }
            pictureBox.Image = bmp;
        }

        private void PlaySound(string filename)
        {
            using (var audioFile = new AudioFileReader(filename))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    System.Threading.Thread.Sleep(100);
                }
            }
        }

        private float[] GenerateGuitarWaveform(double frequency, int duration, int sampleRate, double attackTime, double sustainTime, double releaseTime, double sustainLevel, int stringNumber)
        {
            int samples = sampleRate * duration;
            float[] buffer = new float[samples];

            double k = releaseConstant / releaseTime; // Константа затухания для фазы релиза
            int attackSamples = (int)(attackTime * sampleRate);

            for (int n = 0; n < samples; n++)
            {
                double t = n / (double)sampleRate;

                // Огибающая (envelope)
                double envelope = 0;
                if (t < attackTime)
                {
                    // Экспоненциальная атака
                    envelope = sustainLevel * (1 - Math.Exp(attackExponent * t / attackTime));
                }
                else if (t < attackTime + sustainTime)
                {
                    // Сустейн
                    envelope = sustainLevel;
                }
                else if (t < attackTime + sustainTime + releaseTime)
                {
                    // Экспоненциальный релиз
                    double tRelease = t - attackTime - sustainTime;
                    envelope = sustainLevel * Math.Exp(-k * tRelease);
                }

                // Основной тон и гармоники
                double harmonicSum = 0;
                int harmonics = stringNumber >= 3 ? 10 : 5; // Больше гармоник для басовых струн
                for (int h = 1; h <= harmonics; h++)
                {
                    double freq = frequency * h;
                    if (stringNumber >= 3)
                    {
                        // Добавляем небольшую негармоничность для басовых струн
                        freq *= 1 + inharmonicityFactor * (h - 1) * (h - 1);
                    }
                    harmonicSum += (1.0 / h) * Math.Sin(2 * Math.PI * freq * n / sampleRate);
                }

                // Атака (высокочастотный всплеск)
                if (n < attackSamples)
                {
                    double attackEnvelope = Math.Exp(attackDecay * n / (double)attackSamples); // Экспоненциальное затухание
                    harmonicSum += attackEnvelope * Math.Sin(5 * Math.PI * attackFrequency * n / sampleRate);
                }

                buffer[n] = (float)(envelope * harmonicSum);

                // Нормализация для предотвращения клиппинга
                if (buffer[n] > 1.0f) buffer[n] = 1.0f;
                if (buffer[n] < -1.0f) buffer[n] = -1.0f;
            }

            return buffer;
        }
    }
}