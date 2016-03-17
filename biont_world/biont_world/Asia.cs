using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biont_world
{
    public class Asia:Continent
    {
        public Asia(ListBox displaybox, Random rGen, int types, Graphics canvas)
            :base(displaybox, rGen, types, canvas)
        {
            factory = new AsiaFactory();
        }
    }
}
