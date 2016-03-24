using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComputerCSharp
{
    class RAM:ComputerComponent
    {
        protected string compacity;
        public RAM() { }

        public override string printThis()
        {
            return base.printThis() + compacity;
        }
    }
}
