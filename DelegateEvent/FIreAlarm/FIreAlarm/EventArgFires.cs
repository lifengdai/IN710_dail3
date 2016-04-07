using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    class EventArgFires : EventArgs
    {
        private string message;
        private EFires e;

        public EventArgFires(EFires e)
        {
            this.e = e;
            switch(e)
            {
                case EFires.Minor:
                    message = "Fire is minor";
                    break;

                case EFires.Inferno:
                    message = "Fire is inferno";
                    break;

                case EFires.Serious:
                    message = "Fire is serious";
                    break;
            }
        }

        public string Message
        {
            get
            {
                return message;
            }
        }

        internal EFires E
        {
            get
            {
                return e;
            }
        }
    }
}
