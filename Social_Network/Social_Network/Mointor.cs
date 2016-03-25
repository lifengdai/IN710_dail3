using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network
{
    class Mointor : IPublisher
    {
        private List<Observer> observerList;
        private string status;

        public Mointor()
        {
            observerList = new List<Observer>();
            status = "";
        }

        public void AddSubscriber(ISubscriber subscriber)
        {
            observerList.Add((Observer)subscriber);
        }

        public void NotifySubscriber()
        {
            foreach (Observer O in observerList)
            {
                O.Update(status);
            }
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            observerList.Add((Observer)subscriber);
        }

        public List<Observer> ObserverList
        {
            get
            {
                return observerList;
            }

            set
            {
                observerList = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
    }
}
