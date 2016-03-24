using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MinAndMatchCSharp
{
    class Monstor
    {
        private Bitmap head;
        private Bitmap body;
        private Bitmap legs;

        public Monstor()
        {
            head = null;
            body = null;
            legs = null;
        }

        public static Monstor create(Bitmap head, Bitmap body, Bitmap legs)
        {
            Monstor monstor = new Monstor();
            monstor.head = head;
            monstor.body = body;
            monstor.legs = legs;
            return monstor;
        }

        public Bitmap getHead()
        {
            return head;
        }

        public Bitmap getBody()
        {
            return body;
        }

        public Bitmap getLegs()
        {
            return legs;
        }
    }
}
