using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biont_world
{
    public class Seagull:Animal
    {
        public Seagull()
        {
            name = "seagull";
            family = "laridae";
            food = "fish";
            image = new Bitmap("seagull.jpg");
        }
    }
}
