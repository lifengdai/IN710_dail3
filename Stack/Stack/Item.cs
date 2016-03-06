using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    //You can pass whatever the type you want to MyGenericList
    //without a Next field in it, so this class solve the problem that
    //the type don't have a Next field
    public class Item<L>
    {
        private L item;
        private Item<L> Next;

        public Item()
        {
            Next = null;
        }

        public L Item1
        {
            get { return item; }
            set { item = value; }
        }

        public Item<L> Next1
        {
            get { return Next; }
            set { Next = value; }
        }
    }
}
