using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComputerCSharp
{
    class ComputerComponent
    {
        protected string name;
        protected int price;
        public ComputerComponent()
        {

        }
        public virtual string printThis()
        {
            string display = price.ToString();
            display += "     " + name;
            return display;
        }
        public int getPrice()
        {
            return price;
        }
    }
}
