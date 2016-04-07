using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    class Publisher
    {
        public Publisher() { }

        public delegate void FireAlarmHandler(object o, EventArgFires e);
        public event FireAlarmHandler fireEvent;

        public void OnfirmEvent(EFires e)
        {
            EventArgFires eventArg = new EventArgFires(e);
            if (fireEvent != null)
                fireEvent(this, eventArg);
        }
    }
}
