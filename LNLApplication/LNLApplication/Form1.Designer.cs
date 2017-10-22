namespace LNLApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numQuestionsAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumTimer = new System.Windows.Forms.NumericUpDown();
            this.BoxSubject = new System.Windows.Forms.ComboBox();
            this.BoxDifficulty = new System.Windows.Forms.ComboBox();
            this.BoxGameMode = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuestionsAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(18, 299);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(96, 31);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(120, 299);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(96, 31);
            this.BtnStop.TabIndex = 1;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BtnStop);
            this.groupBox1.Controls.Add(this.numQuestionsAmount);
            this.groupBox1.Controls.Add(this.BtnStart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NumTimer);
            this.groupBox1.Controls.Add(this.BoxSubject);
            this.groupBox1.Controls.Add(this.BoxDifficulty);
            this.groupBox1.Controls.Add(this.BoxGameMode);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 336);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GameSetup";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Amount of questions:";
            // 
            // numQuestionsAmount
            // 
            this.numQuestionsAmount.Location = new System.Drawing.Point(122, 192);
            this.numQuestionsAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuestionsAmount.Name = "numQuestionsAmount";
            this.numQuestionsAmount.Size = new System.Drawing.Size(185, 20);
            this.numQuestionsAmount.TabIndex = 8;
            this.numQuestionsAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numQuestionsAmount.ValueChanged += new System.EventHandler(this.numQuestionsAmount_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Timer (In Seconds):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Difficulty:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Game Mode:";
            // 
            // NumTimer
            // 
            this.NumTimer.Location = new System.Drawing.Point(122, 252);
            this.NumTimer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumTimer.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumTimer.Name = "NumTimer";
            this.NumTimer.Size = new System.Drawing.Size(185, 20);
            this.NumTimer.TabIndex = 3;
            this.NumTimer.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumTimer.ValueChanged += new System.EventHandler(this.NumTimer_ValueChanged);
            // 
            // BoxSubject
            // 
            this.BoxSubject.FormattingEnabled = true;
            this.BoxSubject.Items.AddRange(new object[] {
            "Maths",
            "Geography",
            "Linguistics",
            "Advanced Quantum Physics"});
            this.BoxSubject.Location = new System.Drawing.Point(122, 141);
            this.BoxSubject.Name = "BoxSubject";
            this.BoxSubject.Size = new System.Drawing.Size(185, 21);
            this.BoxSubject.TabIndex = 2;
            this.BoxSubject.SelectedIndexChanged += new System.EventHandler(this.BoxSubject_SelectedIndexChanged);
            // 
            // BoxDifficulty
            // 
            this.BoxDifficulty.AutoCompleteCustomSource.AddRange(new string[] {
            "Easy",
            "Medium",
            "Hard"});
            this.BoxDifficulty.FormattingEnabled = true;
            this.BoxDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.BoxDifficulty.Location = new System.Drawing.Point(122, 83);
            this.BoxDifficulty.Name = "BoxDifficulty";
            this.BoxDifficulty.Size = new System.Drawing.Size(185, 21);
            this.BoxDifficulty.TabIndex = 1;
            this.BoxDifficulty.SelectedIndexChanged += new System.EventHandler(this.BoxDifficulty_SelectedIndexChanged);
            // 
            // BoxGameMode
            // 
            this.BoxGameMode.FormattingEnabled = true;
            this.BoxGameMode.Items.AddRange(new object[] {
            "P.E. Hall",
            "Classroom"});
            this.BoxGameMode.Location = new System.Drawing.Point(122, 30);
            this.BoxGameMode.Name = "BoxGameMode";
            this.BoxGameMode.Size = new System.Drawing.Size(185, 21);
            this.BoxGameMode.TabIndex = 0;
            this.BoxGameMode.SelectedIndexChanged += new System.EventHandler(this.BoxGameMode_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 360);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "LNL - Setup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuestionsAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTimer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numQuestionsAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumTimer;
        private System.Windows.Forms.ComboBox BoxSubject;
        private System.Windows.Forms.ComboBox BoxDifficulty;
        private System.Windows.Forms.ComboBox BoxGameMode;
    }
}

