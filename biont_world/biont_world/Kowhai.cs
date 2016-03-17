using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biont_world
{
    public class Kowhai:Flower
    {
        public Kowhai()
        {
            name = "kowhai";
            family = "fabaceae";
            season = "spring";
            image = new Bitmap("kowhai.jpg");
        }
    }
}
