using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComputerCSharp
{
    interface Ifactory
    {
        ComputerComponent create(int code);
    }
}
