using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biont_world
{
    public class PeachBlossom:Flower
    {
        public PeachBlossom()
        {
            name = "peach blossom";
            family = "Rosaceae";
            season = "spring";
            image = new Bitmap("peach_blossom.jpg");
        }
    }
}
