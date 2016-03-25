using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Monitor
{
    class PreMointor : Mointor
    {
        private double currentPressure;

        public PreMointor()
            : base()
        {
            currentPressure = 0.0;
        }

        public override void NotifySubscriber()
        {
            foreach (Observer ob in observerList)
            {
                ob.Update(2, currentPressure);
            }
        }

        public double CurrentPressure
        {
            get
            {
                return currentPressure;
            }

            set
            {
                currentPressure = value;
            }
        }
    }
}
