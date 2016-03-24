using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComputerCSharp
{
    class CPUfactory : Ifactory
    {
        public CPUfactory() { }

        public ComputerComponent create(int code)
        {
            ComputerComponent cc = null;

            switch (code)
            {
                case 0:
                    cc = new GameCPU();
                    break;
                case 1:
                    cc = new BusinessCPU();
                    break;
                case 2:
                    cc = new MultimediaCPU();
                    break;
            }

            return cc;
        }
    }
}
