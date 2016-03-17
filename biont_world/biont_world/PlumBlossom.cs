using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biont_world
{
    public class PlumBlossom:Flower
    {
        public PlumBlossom()
        {
            name = "plum blossom";
            family = "Rosaceae";
            season = "winter";
            image = new Bitmap("Plum_blossom.jpg");
        }
    }
}
