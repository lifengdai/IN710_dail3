using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAndMatchCSharp
{
    class BodyFactory : Ifactory
    {
        private Body body;

        public BodyFactory()
        {
            body = new Body();
        }

        public Bitmap createBodyparts(string key)
        {
            Bitmap b = null;
            body.Dictionary.TryGetValue(key, out b);
            return b;
        }
    }
}
