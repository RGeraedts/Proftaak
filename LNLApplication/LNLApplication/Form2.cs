using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LNLApplication
{
    public partial class Form2 : Form
    {
        string Gamemode = "";
        string Difficulty = "";
        decimal QuestionAmount = 0;
        decimal QuestionsLeft = 0;
        string Subject = "";
        decimal Timer = 0;
        decimal TimeLeft = 0;
        string Question;
        string Answer1;
        string Answer2;
        bool pressedfirsttime = true;

        public Form2(string gamemode, string subject, decimal questionamount, string difficulty, decimal timer)
        {
            InitializeComponent();
            Gamemode = gamemode;
            QuestionAmount = questionamount;
            QuestionsLeft = questionamount - 1;
            Difficulty = difficulty;
            Subject = subject;
            Timer = timer;
            Startup();
        }

        public void Startup()
        {
            lblGameMode.Text = Gamemode;
            lblTotalQuestions.Text = Convert.ToString(QuestionAmount);
            Quiz();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            
        }

        public void Quiz()
        {
            QuestionTimer.Start();
            GenerateQuestion(Subject);
        }

        private void QuestionTimer_Tick(object sender, EventArgs e)
        {
            if (Timer > 0)
            {
                Timer = Timer - 1;
                LblTimer.Text = Timer + " seconds";
            }
            else
            {
                QuestionTimer.Stop();
                if (QuestionsLeft == 0)
                {

                    
                }
                else
                {
                    NextQuestion();
                    QuestionTimer.Start();
                }

            }
        }

        public void GenerateQuestion(string subject)
        {
            //Check what subject has been entered
            //Get random question from the right subject .txt file
            //Get corresponding questions from that subject .txt file
            //Save Question and Questions into variables.
            //Check which answer is correct(Need to figure this out).
            
        }

        public void NextQuestion()
        {

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (pressedfirsttime == true)
            { 
                QuestionTimer.Stop();
                pressedfirsttime = false;
            }
            else
            {
                QuestionTimer.Start();
                pressedfirsttime = true;
            }
        }
    }
}
