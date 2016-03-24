using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComputerCSharp
{
    class GPUfactory : Ifactory
    {
        public GPUfactory() { }

        public ComputerComponent create(int code)
        {
            ComputerComponent cc = null;

            switch (code)
            {
                case 0:
                    cc = new GameGPU();
                    break;
                case 1:
                    cc = new BusinessGPU();
                    break;
                case 2:
                    cc = new MultimediaGPU();
                    break;
            }

            return cc;
        }
    }
}
