using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bicycle_DashBoard_CSharp
{
    class Observer : ISubscriber
    {
        protected Label label;
        protected BicycleMointor bicycle;
        protected int currentPRM;
        protected double currentComputerValue;

        public Observer(Label label, BicycleMointor bicycle)
        {
            this.bicycle = bicycle;
            this.label = label;
            currentPRM = 0;
            currentComputerValue = 0.0;
            bicycle.AddSubscriber(this);
        }

        public void Display()
        {
            label.Text = currentComputerValue.ToString();
        }

        public virtual void Update<T>(T data)
        {
            currentPRM = Convert.ToInt32(data);
            currentComputerValue = Convert.ToDouble(data);
        }
    }
}
