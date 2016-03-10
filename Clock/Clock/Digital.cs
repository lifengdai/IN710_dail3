using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    class Digital : IClock
    {
        private Label digitalClock;
        private Timer timer;

        public Digital(Label digitalClock, Timer timer)
        {
            this.digitalClock = digitalClock;
            this.timer = timer;
        }

        public void HideClock()
        {
            digitalClock.Hide();
        }

        public void Off()
        {
            timer.Stop();
        }

        public void On()
        {
            UpdateTimeDisplay();
            timer.Start();
        }

        public void ShowClock()
        {
            digitalClock.Show();
        }

        public void UpdateTimeDisplay()
        {
            DateTime datetime = DateTime.Now;
            string hours = datetime.Hour.ToString();
            string mins = datetime.Minute.ToString();
            string sec = datetime.Second.ToString();

            digitalClock.Text = hours + ":" + mins + ":" + sec;
        }
    }
}
