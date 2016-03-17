using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biont_world
{
    public class Kea:Animal
    {
        public Kea()
        {
            name = "kea";
            family = "Nestoridae";
            food = "seeds";
            image = new Bitmap("kea.jpg");
        }
    }
}
