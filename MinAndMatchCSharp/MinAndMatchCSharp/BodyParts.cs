using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MinAndMatchCSharp
{
    abstract class BodyParts
    {
        protected Dictionary<string, Bitmap> dictionary;

        public BodyParts()
        {
            dictionary = new Dictionary<string, Bitmap>();
        }

	    protected abstract void addParts();

	    protected virtual Bitmap createBitmap(string file)
        {
            return new Bitmap(new Bitmap(file), new Size(250, 250));
        }

        public Dictionary<string, Bitmap> Dictionary
        {
            get
            {
                return dictionary;
            }
        }
    }
}
