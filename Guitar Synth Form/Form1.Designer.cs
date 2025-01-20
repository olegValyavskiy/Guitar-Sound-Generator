namespace GuitarSoundGenerator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.NumericUpDown numSampleRate;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.NumericUpDown numAttackTime;
        private System.Windows.Forms.NumericUpDown numReleaseTime;
        private System.Windows.Forms.NumericUpDown numSustainLevel;
        private System.Windows.Forms.NumericUpDown numAttackExponent;
        private System.Windows.Forms.NumericUpDown numReleaseConstant;
        private System.Windows.Forms.NumericUpDown numAttackFrequency;
        private System.Windows.Forms.NumericUpDown numAttackDecay;
        private System.Windows.Forms.NumericUpDown numInharmonicityFactor;
        private System.Windows.Forms.Label labelSampleRate;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelAttackTime;
        private System.Windows.Forms.Label labelReleaseTime;
        private System.Windows.Forms.Label labelSustainLevel;
        private System.Windows.Forms.Label labelAttackExponent;
        private System.Windows.Forms.Label labelReleaseConstant;
        private System.Windows.Forms.Label labelAttackFrequency;
        private System.Windows.Forms.Label labelAttackDecay;
        private System.Windows.Forms.Label labelInharmonicityFactor;
        private System.Windows.Forms.Button btnPlayLastSound;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.numSampleRate = new System.Windows.Forms.NumericUpDown();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.numAttackTime = new System.Windows.Forms.NumericUpDown();
            this.numReleaseTime = new System.Windows.Forms.NumericUpDown();
            this.numSustainLevel = new System.Windows.Forms.NumericUpDown();
            this.numAttackExponent = new System.Windows.Forms.NumericUpDown();
            this.numReleaseConstant = new System.Windows.Forms.NumericUpDown();
            this.numAttackFrequency = new System.Windows.Forms.NumericUpDown();
            this.numAttackDecay = new System.Windows.Forms.NumericUpDown();
            this.numInharmonicityFactor = new System.Windows.Forms.NumericUpDown();
            this.labelSampleRate = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelAttackTime = new System.Windows.Forms.Label();
            this.labelReleaseTime = new System.Windows.Forms.Label();
            this.labelSustainLevel = new System.Windows.Forms.Label();
            this.labelAttackExponent = new System.Windows.Forms.Label();
            this.labelReleaseConstant = new System.Windows.Forms.Label();
            this.labelAttackFrequency = new System.Windows.Forms.Label();
            this.labelAttackDecay = new System.Windows.Forms.Label();
            this.labelInharmonicityFactor = new System.Windows.Forms.Label();
            this.btnPlayLastSound = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSampleRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReleaseTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSustainLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackExponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReleaseConstant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackDecay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInharmonicityFactor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(211, 390);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(160, 30);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Генерировать звуки";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(200, 20);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(686, 300);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // numSampleRate
            // 
            this.numSampleRate.Location = new System.Drawing.Point(20, 40);
            this.numSampleRate.Maximum = new decimal(new int[] {
            96000,
            0,
            0,
            0});
            this.numSampleRate.Minimum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.numSampleRate.Name = "numSampleRate";
            this.numSampleRate.Size = new System.Drawing.Size(150, 20);
            this.numSampleRate.TabIndex = 2;
            this.numSampleRate.Value = new decimal(new int[] {
            44100,
            0,
            0,
            0});
            // 
            // numDuration
            // 
            this.numDuration.Location = new System.Drawing.Point(20, 80);
            this.numDuration.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(150, 20);
            this.numDuration.TabIndex = 3;
            this.numDuration.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numAttackTime
            // 
            this.numAttackTime.DecimalPlaces = 2;
            this.numAttackTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numAttackTime.Location = new System.Drawing.Point(20, 120);
            this.numAttackTime.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAttackTime.Name = "numAttackTime";
            this.numAttackTime.Size = new System.Drawing.Size(150, 20);
            this.numAttackTime.TabIndex = 4;
            this.numAttackTime.Value = new decimal(new int[] {
            12,
            0,
            0,
            131072});
            // 
            // numReleaseTime
            // 
            this.numReleaseTime.DecimalPlaces = 2;
            this.numReleaseTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numReleaseTime.Location = new System.Drawing.Point(20, 160);
            this.numReleaseTime.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numReleaseTime.Name = "numReleaseTime";
            this.numReleaseTime.Size = new System.Drawing.Size(150, 20);
            this.numReleaseTime.TabIndex = 5;
            this.numReleaseTime.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numSustainLevel
            // 
            this.numSustainLevel.DecimalPlaces = 2;
            this.numSustainLevel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numSustainLevel.Location = new System.Drawing.Point(20, 200);
            this.numSustainLevel.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSustainLevel.Name = "numSustainLevel";
            this.numSustainLevel.Size = new System.Drawing.Size(150, 20);
            this.numSustainLevel.TabIndex = 6;
            this.numSustainLevel.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // numAttackExponent
            // 
            this.numAttackExponent.DecimalPlaces = 2;
            this.numAttackExponent.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numAttackExponent.Location = new System.Drawing.Point(20, 240);
            this.numAttackExponent.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numAttackExponent.Name = "numAttackExponent";
            this.numAttackExponent.Size = new System.Drawing.Size(150, 20);
            this.numAttackExponent.TabIndex = 7;
            this.numAttackExponent.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // numReleaseConstant
            // 
            this.numReleaseConstant.DecimalPlaces = 2;
            this.numReleaseConstant.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numReleaseConstant.Location = new System.Drawing.Point(20, 280);
            this.numReleaseConstant.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numReleaseConstant.Name = "numReleaseConstant";
            this.numReleaseConstant.Size = new System.Drawing.Size(150, 20);
            this.numReleaseConstant.TabIndex = 8;
            this.numReleaseConstant.Value = new decimal(new int[] {
            14,
            0,
            0,
            65536});
            // 
            // numAttackFrequency
            // 
            this.numAttackFrequency.Location = new System.Drawing.Point(20, 320);
            this.numAttackFrequency.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numAttackFrequency.Name = "numAttackFrequency";
            this.numAttackFrequency.Size = new System.Drawing.Size(150, 20);
            this.numAttackFrequency.TabIndex = 9;
            this.numAttackFrequency.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // numAttackDecay
            // 
            this.numAttackDecay.DecimalPlaces = 2;
            this.numAttackDecay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numAttackDecay.Location = new System.Drawing.Point(20, 360);
            this.numAttackDecay.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numAttackDecay.Name = "numAttackDecay";
            this.numAttackDecay.Size = new System.Drawing.Size(150, 20);
            this.numAttackDecay.TabIndex = 10;
            this.numAttackDecay.Value = new decimal(new int[] {
            8,
            0,
            0,
            -2147483648});
            // 
            // numInharmonicityFactor
            // 
            this.numInharmonicityFactor.DecimalPlaces = 4;
            this.numInharmonicityFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numInharmonicityFactor.Location = new System.Drawing.Point(20, 400);
            this.numInharmonicityFactor.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInharmonicityFactor.Name = "numInharmonicityFactor";
            this.numInharmonicityFactor.Size = new System.Drawing.Size(150, 20);
            this.numInharmonicityFactor.TabIndex = 11;
            this.numInharmonicityFactor.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // labelSampleRate
            // 
            this.labelSampleRate.AutoSize = true;
            this.labelSampleRate.Location = new System.Drawing.Point(20, 20);
            this.labelSampleRate.Name = "labelSampleRate";
            this.labelSampleRate.Size = new System.Drawing.Size(73, 13);
            this.labelSampleRate.TabIndex = 12;
            this.labelSampleRate.Text = "Частота (Гц):";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(20, 60);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(110, 13);
            this.labelDuration.TabIndex = 13;
            this.labelDuration.Text = "Длительность (сек):";
            // 
            // labelAttackTime
            // 
            this.labelAttackTime.AutoSize = true;
            this.labelAttackTime.Location = new System.Drawing.Point(20, 100);
            this.labelAttackTime.Name = "labelAttackTime";
            this.labelAttackTime.Size = new System.Drawing.Size(90, 13);
            this.labelAttackTime.TabIndex = 14;
            this.labelAttackTime.Text = "Время атаки (с):";
            // 
            // labelReleaseTime
            // 
            this.labelReleaseTime.AutoSize = true;
            this.labelReleaseTime.Location = new System.Drawing.Point(20, 140);
            this.labelReleaseTime.Name = "labelReleaseTime";
            this.labelReleaseTime.Size = new System.Drawing.Size(97, 13);
            this.labelReleaseTime.TabIndex = 15;
            this.labelReleaseTime.Text = "Время релиза (с):";
            // 
            // labelSustainLevel
            // 
            this.labelSustainLevel.AutoSize = true;
            this.labelSustainLevel.Location = new System.Drawing.Point(20, 180);
            this.labelSustainLevel.Name = "labelSustainLevel";
            this.labelSustainLevel.Size = new System.Drawing.Size(103, 13);
            this.labelSustainLevel.TabIndex = 16;
            this.labelSustainLevel.Text = "Уровень сустейна:";
            // 
            // labelAttackExponent
            // 
            this.labelAttackExponent.AutoSize = true;
            this.labelAttackExponent.Location = new System.Drawing.Point(20, 220);
            this.labelAttackExponent.Name = "labelAttackExponent";
            this.labelAttackExponent.Size = new System.Drawing.Size(102, 13);
            this.labelAttackExponent.TabIndex = 17;
            this.labelAttackExponent.Text = "Экспонента атаки:";
            // 
            // labelReleaseConstant
            // 
            this.labelReleaseConstant.AutoSize = true;
            this.labelReleaseConstant.Location = new System.Drawing.Point(20, 260);
            this.labelReleaseConstant.Name = "labelReleaseConstant";
            this.labelReleaseConstant.Size = new System.Drawing.Size(117, 13);
            this.labelReleaseConstant.TabIndex = 18;
            this.labelReleaseConstant.Text = "Константа релиза (k):";
            // 
            // labelAttackFrequency
            // 
            this.labelAttackFrequency.AutoSize = true;
            this.labelAttackFrequency.Location = new System.Drawing.Point(20, 300);
            this.labelAttackFrequency.Name = "labelAttackFrequency";
            this.labelAttackFrequency.Size = new System.Drawing.Size(105, 13);
            this.labelAttackFrequency.TabIndex = 19;
            this.labelAttackFrequency.Text = "Частота атаки (Гц):";
            // 
            // labelAttackDecay
            // 
            this.labelAttackDecay.AutoSize = true;
            this.labelAttackDecay.Location = new System.Drawing.Point(20, 340);
            this.labelAttackDecay.Name = "labelAttackDecay";
            this.labelAttackDecay.Size = new System.Drawing.Size(94, 13);
            this.labelAttackDecay.TabIndex = 20;
            this.labelAttackDecay.Text = "Затухание атаки:";
            // 
            // labelInharmonicityFactor
            // 
            this.labelInharmonicityFactor.AutoSize = true;
            this.labelInharmonicityFactor.Location = new System.Drawing.Point(20, 380);
            this.labelInharmonicityFactor.Name = "labelInharmonicityFactor";
            this.labelInharmonicityFactor.Size = new System.Drawing.Size(172, 13);
            this.labelInharmonicityFactor.TabIndex = 21;
            this.labelInharmonicityFactor.Text = "Коэффициент негармоничности:";
            // 
            // btnPlayLastSound
            // 
            this.btnPlayLastSound.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlayLastSound.Location = new System.Drawing.Point(726, 390);
            this.btnPlayLastSound.Name = "btnPlayLastSound";
            this.btnPlayLastSound.Size = new System.Drawing.Size(160, 30);
            this.btnPlayLastSound.TabIndex = 22;
            this.btnPlayLastSound.Text = "Воспроизвести последний звук";
            this.btnPlayLastSound.UseVisualStyleBackColor = true;
            this.btnPlayLastSound.Click += new System.EventHandler(this.btnPlayLastSound_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 432);
            this.Controls.Add(this.btnPlayLastSound);
            this.Controls.Add(this.labelInharmonicityFactor);
            this.Controls.Add(this.labelAttackDecay);
            this.Controls.Add(this.labelAttackFrequency);
            this.Controls.Add(this.labelReleaseConstant);
            this.Controls.Add(this.labelAttackExponent);
            this.Controls.Add(this.labelSustainLevel);
            this.Controls.Add(this.labelReleaseTime);
            this.Controls.Add(this.labelAttackTime);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelSampleRate);
            this.Controls.Add(this.numInharmonicityFactor);
            this.Controls.Add(this.numAttackDecay);
            this.Controls.Add(this.numAttackFrequency);
            this.Controls.Add(this.numReleaseConstant);
            this.Controls.Add(this.numAttackExponent);
            this.Controls.Add(this.numSustainLevel);
            this.Controls.Add(this.numReleaseTime);
            this.Controls.Add(this.numAttackTime);
            this.Controls.Add(this.numDuration);
            this.Controls.Add(this.numSampleRate);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Генератор звуков гитары";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSampleRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReleaseTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSustainLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackExponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReleaseConstant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackDecay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInharmonicityFactor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}