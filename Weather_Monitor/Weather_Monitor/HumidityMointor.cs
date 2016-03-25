using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Monitor
{
    class HumidityMointor : Mointor
    {
        private double currentHumidity;

        public HumidityMointor()
            : base()
        {
            currentHumidity = 0.0;
        }

        public override void NotifySubscriber()
        {
            foreach (Observer ob in observerList)
            {
                ob.Update(1, currentHumidity);
            }
        }

        public double CurrentHumidity
        {
            get
            {
                return currentHumidity;
            }

            set
            {
                currentHumidity = value;
            }
        }
    }
}
