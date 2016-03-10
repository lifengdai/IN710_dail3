using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalogClockControl;

namespace Clock
{
    class Choser
    {
        private IClock clock;

        public Choser(AnalogClock alc)
        {
            clock = new Analogue(alc);
        }

        public void HideClock()
        {
            clock.HideClock();
        }

        public void Off()
        {
            clock.Off();
        }

        public void On()
        {
            clock.On();
        }

        public void ShowClock()
        {
            clock.ShowClock();
        }

        public void UpdateTimeDisplay()
        {
            clock.UpdateTimeDisplay();
        }

        public IClock Clock
        {
            get
            {
                return clock;
            }

            set
            {
                clock = value;
            }
        }
    }
}
