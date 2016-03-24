using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAndMatchCSharp
{
    class LegsFactory : Ifactory
    {
        private Legs legs;

        public LegsFactory()
        {
            legs = new Legs();
        }

        public Bitmap createBodyparts(string key)
        {
            Bitmap b = null;
            legs.Dictionary.TryGetValue(key, out b);
            return b;
        }
    }
}
