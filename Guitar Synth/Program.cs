using System;
using System.IO;
using NAudio.Wave;

namespace GuitarSoundGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define constants
            const int sampleRate = 44100;
            const int bitsPerSample = 16;
            const int channels = 1;
            const int duration = 2; // seconds
            const int maxFret = 12;
            const double attackTime = 0.12; // 60 ms for attack
            const double releaseTime = 2.0; // seconds
            const double sustainLevel = 0.5;
            const double sustainTime = duration - attackTime - releaseTime;

            // Create directory if not exists
            string directory = "sounds";
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Open string frequencies (string 5 to 0)
            double[] openFrequencies = new double[]
            {
                82.41,  // E2 - string 5
                110.00, // A2 - string 4
                146.82, // D3 - string 3
                196.00, // G3 - string 2
                246.94, // H3 - string 1
                329.63  // E4 - string 0
            };

            // Precompute frequencies for all strings and frets
            for (int stringNumber = 5; stringNumber >= 0; stringNumber--)
            {
                double openFrequency = openFrequencies[stringNumber];
                for (int fret = 0; fret <= maxFret; fret++)
                {
                    // Calculate frequency
                    double frequency = openFrequency * Math.Pow(2, fret / 12.0);

                    // Generate the waveform samples
                    float[] samples = GenerateGuitarWaveform(frequency, duration, sampleRate, attackTime, sustainTime, releaseTime, sustainLevel, stringNumber);

                    // Convert float samples to 16-bit PCM
                    short[] pcmSamples = new short[samples.Length];
                    for (int i = 0; i < samples.Length; i++)
                    {
                        pcmSamples[i] = (short)(samples[i] * short.MaxValue);
                    }

                    // Create filename
                    string filename = Path.Combine(directory, $"string{stringNumber}tone{fret}.wav");

                    // Write the PCM data to a Wave file
                    using (WaveFileWriter writer = new WaveFileWriter(filename, new WaveFormat(sampleRate, bitsPerSample, channels)))
                    {
                        writer.WriteSamples(pcmSamples, 0, pcmSamples.Length);
                    }

                    Console.WriteLine($"Generated {filename}");
                }
            }

            Console.WriteLine("All sounds generated.");
        }

        static float[] GenerateGuitarWaveform(double frequency, int duration, int sampleRate, double attackTime, double sustainTime, double releaseTime, double sustainLevel, int stringNumber)
        {
            int samples = sampleRate * duration;
            float[] buffer = new float[samples];

            double k = 1.4 / releaseTime; // Decay constant for release phase
            int attackSamples = (int)(attackTime * sampleRate);

            for (int n = 0; n < samples; n++)
            {
                double t = n / (double)sampleRate;

                double envelope = 0;
                if (t < attackTime)
                {
                    // Exponential attack
                    envelope = sustainLevel * (1 - Math.Exp(-10 * t / attackTime));
                }
                else if (t < attackTime + sustainTime)
                {
                    // Sustain
                    envelope = sustainLevel;
                }
                else if (t < attackTime + sustainTime + releaseTime)
                {
                    // Exponential release
                    double tRelease = t - attackTime - sustainTime;
                    envelope = sustainLevel * Math.Exp(-k * tRelease);
                }

                // Fundamental and harmonics
                double harmonicSum = 0;
                int harmonics = stringNumber >= 3 ? 10 : 5; // More harmonics for wound strings
                for (int h = 1; h <= harmonics; h++)
                {
                    double freq = frequency * h;
                    if (stringNumber >= 3)
                    {
                        // Introduce slight inharmonicity for wound strings
                        freq *= 1 + 0.001 * (h - 1) * (h - 1);
                    }
                    harmonicSum += (1.0 / h) * Math.Sin(2 * Math.PI * freq * n / sampleRate);
                }

                // Attack burst for the first 60 ms
                if (n < attackSamples)
                {
                    double attackFreq = 2500.0; // High-frequency attack
                    double attackEnvelope = Math.Exp(-8 * n / (double)attackSamples); // Exponential decay
                    harmonicSum += attackEnvelope * Math.Sin(5 * Math.PI * attackFreq * n / sampleRate);
                }

                buffer[n] = (float)(envelope * harmonicSum);

                // Normalize to prevent clipping
                if (buffer[n] > 1.0f) buffer[n] = 1.0f;
                if (buffer[n] < -1.0f) buffer[n] = -1.0f;
            }

            return buffer;
        }
    }
}