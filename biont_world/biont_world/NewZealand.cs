using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biont_world
{
    public class NewZealand:Continent
    {
        public NewZealand(ListBox displaybox, Random rGen, int types, Graphics canvas)
            :base(displaybox, rGen, types, canvas)
        {
            factory = new NewZealandFactory();
        }
    }
}
