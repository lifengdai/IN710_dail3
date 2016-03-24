using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComputerCSharp
{
    class CPU:ComputerComponent
    {
        protected string speed;
        protected string numOfCore;

        public CPU() { }

        public override string printThis()
        {
            return base.printThis() + numOfCore + ", " + speed;
        }

    }
}
