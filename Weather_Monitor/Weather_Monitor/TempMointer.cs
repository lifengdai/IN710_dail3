using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Monitor
{
    class TempMointer : Mointor
    {
        private List<double> temp;
        private double currectTemp;

        public TempMointer()
        {
            temp = new List<double>();
            currectTemp = 0.0;
        }

        public override void NotifySubscriber()
        {
            foreach (Observer ob in observerList)
            {
                ob.Update(0, currectTemp);
            }
        }

        public double CurrectTemp
        {
            get
            {
                return currectTemp;
            }

            set
            {
                currectTemp = value;
            }
        }
    }
}
