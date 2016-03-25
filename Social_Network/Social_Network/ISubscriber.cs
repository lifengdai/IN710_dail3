using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network
{
    interface ISubscriber
    {
        void Display();
        void Update<T>(T data);
    }
}
