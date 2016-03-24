using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComputerCSharp
{
    class BusinessCPU:CPU
    {
        public BusinessCPU()
        {
            price = 281;
            name = "Intel 5-gen i5";
            speed = "2.2GHz";
            numOfCore = "Dual";
        }
    }
}
