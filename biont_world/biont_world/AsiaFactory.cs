using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biont_world
{
    public class AsiaFactory : iFactory
    {
        public AsiaFactory() { }

        public Biont create(int code)
        {
            Biont biont = null;

            switch (code)
            {
                case 0:
                    biont = new CherryBlossom();
                    break;
                case 1:
                    biont = new PeachBlossom();
                    break;
                case 2:
                    biont = new PlumBlossom();
                    break;
            }
            return biont;
        }
    }
}
