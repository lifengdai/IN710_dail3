using System;
using System.Windows.Forms;

namespace QuizNight
{
    public partial class Form1 : Form
    {
        private delegate int CalScore(int correct, int incorrect);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            CalScore calsScore = null;

            int correct = Convert.ToInt32(txtCorrectAnswer.Text);
            int incorrect = Convert.ToInt32(txtIncorrectAnswer.Text);

            if (rdobtnAdult.Checked)
            {
                calsScore = new CalScore(Scorer.AdultScore);
            }

            if (rdobtnChild.Checked)
            {
                calsScore = new CalScore(Scorer.ChildScore);
            }

            lblScore.Text = calsScore(correct, incorrect).ToString();
        }
    }
}
