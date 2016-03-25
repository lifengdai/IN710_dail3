using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Monitor
{
    interface ISubscriber
    {
        void Display();
        void Update<T>(int code, T data);
        void Register(Mointor mointor);
    }
}
