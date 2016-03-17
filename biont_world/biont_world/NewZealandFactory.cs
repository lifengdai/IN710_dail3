using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biont_world
{
    public class NewZealandFactory : iFactory
    {
        public NewZealandFactory() { }

        public Biont create(int code)
        {
            Biont biont = null;

            switch (code)
            {
                case 0:
                    biont = new Kakapo();
                    break;
                case 1:
                    biont = new Kea();
                    break;
                case 2:
                    biont = new Kiwi();
                    break;
                case 3:
                    biont = new Seagull();
                    break;
                case 4:
                    biont = new Kowhai();
                    break;
            }
            return biont;
        }
    }
}
