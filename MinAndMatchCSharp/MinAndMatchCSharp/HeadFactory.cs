using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAndMatchCSharp
{
    class HeadFactory : Ifactory
    {
        private Head head;

        public HeadFactory()
        {
            head = new Head();
        }

        public Bitmap createBodyparts(string key)
        {
            Bitmap b = null;
            head.Dictionary.TryGetValue(key, out b);
            return b;
        }
    }
}
