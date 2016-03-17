using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biont_world
{
    public class Flower:Biont
    {
        protected string season;

        public Flower() { }

        public override string ToString()
        {
            return base.ToString() + ". Season is " + season;
        }
    }
}
