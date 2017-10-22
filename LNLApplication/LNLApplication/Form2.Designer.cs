namespace LNLApplication
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.LblTimeRemaining = new System.Windows.Forms.Label();
            this.LblTimer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGameMode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.GrpColorValues = new System.Windows.Forms.GroupBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalQuestions = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQuestionsLeft = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.QuestionTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTimeRemaining
            // 
            this.LblTimeRemaining.AutoSize = true;
            this.LblTimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LblTimeRemaining.Location = new System.Drawing.Point(502, 23);
            this.LblTimeRemaining.Name = "LblTimeRemaining";
            this.LblTimeRemaining.Size = new System.Drawing.Size(188, 29);
            this.LblTimeRemaining.TabIndex = 0;
            this.LblTimeRemaining.Text = "Time remaining:";
            // 
            // LblTimer
            // 
            this.LblTimer.AutoSize = true;
            this.LblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LblTimer.Location = new System.Drawing.Point(708, 23);
            this.LblTimer.Name = "LblTimer";
            this.LblTimer.Size = new System.Drawing.Size(58, 29);
            this.LblTimer.TabIndex = 1;
            this.LblTimer.Text = "0:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current game mode:";
            // 
            // lblGameMode
            // 
            this.lblGameMode.AutoSize = true;
            this.lblGameMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblGameMode.Location = new System.Drawing.Point(263, 23);
            this.lblGameMode.Name = "lblGameMode";
            this.lblGameMode.Size = new System.Drawing.Size(140, 29);
            this.lblGameMode.TabIndex = 3;
            this.lblGameMode.Text = "GameMode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(24, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current Question:";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblQuestion.Location = new System.Drawing.Point(293, 333);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(110, 29);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "Question";
            // 
            // GrpColorValues
            // 
            this.GrpColorValues.Location = new System.Drawing.Point(507, 90);
            this.GrpColorValues.Name = "GrpColorValues";
            this.GrpColorValues.Size = new System.Drawing.Size(355, 372);
            this.GrpColorValues.TabIndex = 6;
            this.GrpColorValues.TabStop = false;
            this.GrpColorValues.Text = "Color Values";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(507, 482);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 77);
            this.btnPause.TabIndex = 7;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(603, 482);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 77);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(21, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Question number:";
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblQuestionNumber.Location = new System.Drawing.Point(377, 172);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(26, 29);
            this.lblQuestionNumber.TabIndex = 10;
            this.lblQuestionNumber.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(21, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total amount of questions:";
            // 
            // lblTotalQuestions
            // 
            this.lblTotalQuestions.AutoSize = true;
            this.lblTotalQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTotalQuestions.Location = new System.Drawing.Point(377, 106);
            this.lblTotalQuestions.Name = "lblTotalQuestions";
            this.lblTotalQuestions.Size = new System.Drawing.Size(26, 29);
            this.lblTotalQuestions.TabIndex = 12;
            this.lblTotalQuestions.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(24, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Questions left: ";
            // 
            // lblQuestionsLeft
            // 
            this.lblQuestionsLeft.AutoSize = true;
            this.lblQuestionsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblQuestionsLeft.Location = new System.Drawing.Point(377, 241);
            this.lblQuestionsLeft.Name = "lblQuestionsLeft";
            this.lblQuestionsLeft.Size = new System.Drawing.Size(26, 29);
            this.lblQuestionsLeft.TabIndex = 14;
            this.lblQuestionsLeft.Text = "4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(268, 399);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 133);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.Location = new System.Drawing.Point(24, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Previous Answer:";
            // 
            // QuestionTimer
            // 
            this.QuestionTimer.Tick += new System.EventHandler(this.QuestionTimer_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 571);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblQuestionsLeft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalQuestions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblQuestionNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.GrpColorValues);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblGameMode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTimer);
            this.Controls.Add(this.LblTimeRemaining);
            this.Name = "Form2";
            this.Text = "LNL - Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTimeRemaining;
        private System.Windows.Forms.Label LblTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGameMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox GrpColorValues;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalQuestions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblQuestionsLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer QuestionTimer;
    }
}