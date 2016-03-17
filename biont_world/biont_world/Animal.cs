using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biont_world
{
    public class Animal:Biont
    {
        protected string food;

        public Animal() { }

        public override string ToString()
        {
            return base.ToString() + ". I eat " +food;
        }
    }
}
