using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalogClockControl;

namespace Clock
{
    class Analogue:IClock
    {
        private AnalogClock analogClock;

        public Analogue(AnalogClock analogClock)
        {
            this.analogClock = analogClock;
        }

        public void On()
        {
            analogClock.Start();
        }

        public void Off()
        {
            analogClock.Stop();
        }

        public void UpdateTimeDisplay()
        {
            analogClock.Start();
            analogClock.Validate();
        }

        public void ShowClock()
        {
            analogClock.Show();
        }

        public void HideClock()
        {
            analogClock.Hide();
        }
    }
}
