using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Monitor
{
    class Mointor : IPublisher
    {
        protected List<Observer> observerList;

        public Mointor()
        {
            observerList = new List<Observer>();
        }

        public void AddSubscriber(ISubscriber subscriber)
        {
            observerList.Add((Observer)subscriber);
        }

        public virtual void NotifySubscriber() { }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            observerList.Remove((Observer)subscriber);
        }
    }
}
