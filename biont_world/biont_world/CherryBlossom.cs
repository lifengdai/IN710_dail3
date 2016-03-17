using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biont_world
{
    public class CherryBlossom:Flower
    {
        public CherryBlossom()
        {
            name = "cherry blossom";
            family = "rosaceae";
            season = "spring";
            image = new Bitmap("cherry_blossom.png");
        }
    }
}
