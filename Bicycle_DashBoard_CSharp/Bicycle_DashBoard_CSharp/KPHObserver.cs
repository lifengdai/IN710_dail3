using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bicycle_DashBoard_CSharp
{
    class KPHObserver : Observer
    {
        public KPHObserver(Label label, BicycleMointor bicycle)
            :base(label, bicycle)
        {
        }

        public override void Update<T>(T data)
        {
            currentPRM = Convert.ToInt32(data);
            currentComputerValue = Convert.ToDouble(data) * 0.00205 * 60.0;
        }
    }
}
