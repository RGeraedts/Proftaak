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
    public partial class Form1 : Form
    {
        string Gamemode = "";
        string Difficulty = "";
        decimal QuestionAmount = 0;
        string Subject = "";
        decimal Timer = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            QuestionAmount = numQuestionsAmount.Value;
            Timer = NumTimer.Value;
            Form2 frm2 = new Form2(Gamemode, Subject, QuestionAmount, Difficulty, Timer);
            frm2.Show();
        }

        public void CanStartBePressed()
        {
            if(Gamemode != "" && Difficulty != "" && QuestionAmount != 0 && Subject != "" && Timer != 0)
            {

            }
        }

        private void BoxGameMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gamemode = BoxGameMode.Text;
        }

        private void BoxDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Difficulty = BoxDifficulty.Text;
        }

        private void BoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            Subject = BoxSubject.Text;
        }

        private void numQuestionsAmount_ValueChanged(object sender, EventArgs e)
        {
            QuestionAmount = numQuestionsAmount.Value;
        }

        private void NumTimer_ValueChanged(object sender, EventArgs e)
        {
            Timer = NumTimer.Value;
        }
    }
}
