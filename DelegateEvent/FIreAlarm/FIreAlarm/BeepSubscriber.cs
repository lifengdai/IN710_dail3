using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    class BeepSubscriber : Subscriber
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int freq, int duration);
        public BeepSubscriber(Publisher subject) : base(subject) { }

        public override void Alarm(object o, EventArgFires e)
        {
            switch(e.E)
            {
                case EFires.Minor:
                    Beep(800, 1000);
                    break;

                case EFires.Serious:
                    Beep(1500, 1000);
                    break;

                case EFires.Inferno:
                    Beep(2200, 1000);
                    break;
            }
        }
    }
}
