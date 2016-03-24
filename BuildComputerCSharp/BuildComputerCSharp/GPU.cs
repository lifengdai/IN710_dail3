using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComputerCSharp
{
    class GPU:ComputerComponent
    {
        protected string compacity;
        protected string memoryInterface;

        public GPU() { }

        public override string printThis()
        {
            return base.printThis() + ", " + compacity + ", " + memoryInterface;
        }
    }
}
