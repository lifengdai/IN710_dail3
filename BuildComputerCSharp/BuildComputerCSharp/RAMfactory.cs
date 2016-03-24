using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComputerCSharp
{
    class RAMfactory : Ifactory
    {
        public RAMfactory() { }

        public ComputerComponent create(int code)
        {
            ComputerComponent cc = null;

            switch (code)
            {
                case 0:
                    cc = new GameRAM();
                    break;
                case 1:
                    cc = new BusinessRAM();
                    break;
                case 2:
                    cc = new MultimediaRAM();
                    break;
            }

            return cc;
        }
    }
}
