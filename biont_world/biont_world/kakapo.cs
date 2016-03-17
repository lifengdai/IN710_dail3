using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biont_world
{
    public class Kakapo:Animal
    {
        public Kakapo()
        {
            name = "kakapo";
            family = "Nestoridae";
            food = "seeds";
            image = new Bitmap("kakapo.jpg");
        }
    }
}
