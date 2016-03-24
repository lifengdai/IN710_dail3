using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle_DashBoard_CSharp
{
    class BicycleMointor : IPublisher
    {
        private List<Observer> observerList;
        private int currentRPM;

        public BicycleMointor()
        {
            observerList = new List<Observer>();
            currentRPM = 0;
        }

        public void NotifySubscriber()
        {
            foreach(Observer o in observerList)
            {
                o.Update(currentRPM);
            }
        }

        public void AddSubscriber(ISubscriber subscriber)
        {
            observerList.Add((Observer)subscriber);
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            observerList.Remove((Observer)subscriber);
        }

        public int CurrentRPM
        {
            get
            {
                return currentRPM;
            }

            set
            {
                currentRPM = value;
            }
        }
    }
}
