using System;
using System.Threading;
using System.Windows.Forms;

namespace PrograssIndicator
{
    public partial class Form1 : Form 
    {
        private delegate void FeedBackDelegate();

        public Form1()
        {
            InitializeComponent();
        }

        private void updateProgressBar()
        {
            progressBar.PerformStep();
        }

        private void updateSpainBox()
        {
            numericUpDown.Value++;
            Application.DoEvents();
        }

        private void updateTrackBar()
        {
            trackBar.Value++;
        }

        private void doingHeavyWork(FeedBackDelegate feedBack)
        {          
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                feedBack();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bool Checked = false;
            FeedBackDelegate feedBack = null;

            if (rdobtnSpinBox.Checked)
            {
                feedBack = new FeedBackDelegate(updateSpainBox);
                Checked = true;
            }

            if (rdobtnProgressBar.Checked)
            {
                feedBack = new FeedBackDelegate(updateProgressBar);
                Checked = true;
            }

            if (rdobtnTrackBar.Checked)
            {
                feedBack = new FeedBackDelegate(updateTrackBar);
                Checked = true;
            }

            if (Checked)
            {
                doingHeavyWork(feedBack);
                Checked = false;
            }
        }
    }
}
