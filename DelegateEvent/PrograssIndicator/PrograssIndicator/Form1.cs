using System;
using System.Threading;
using System.Windows.Forms;

namespace PrograssIndicator
{
    public partial class Form1 : Form 
    {
        private ProgressSubject ps;
        private SpainBoxSubscriber sbs;
        private TrackbarSubscriber tbs;
        private ProgressBarSubscriber pbs;

        public Form1()
        {
            InitializeComponent();
            ps = new ProgressSubject();
            sbs = new SpainBoxSubscriber(ps, numericUpDown);
            tbs = new TrackbarSubscriber(ps, trackBar);
            pbs = new ProgressBarSubscriber(ps, progressBar);
        }

        //private void updateProgressBar()
        //{
        //    progressBar.PerformStep();
        //}

        //private void updateSpainBox()
        //{
        //    numericUpDown.Value++;
        //    Application.DoEvents();
        //}

        //private void updateTrackBar()
        //{
        //    trackBar.Value++;
        //}

        //private void doingHeavyWork(FeedBackDelegate feedBack)
        //{          
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Thread.Sleep(200);
        //        feedBack();
        //    }
        //}

        private void btnStart_Click(object sender, EventArgs e)
        {
            ps.SlowWork();
        }
    }
}
