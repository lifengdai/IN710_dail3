using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    abstract class Subscriber
    {
        protected Publisher subject;

        public Subscriber(Publisher subject)
        {
            this.subject = subject;
            subject.fireEvent += new Publisher.FireAlarmHandler(Alarm);
        }

        public abstract void Alarm(object o, EventArgFires e);
    }
}
