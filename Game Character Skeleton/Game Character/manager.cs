using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class manager
    {
        private List<Characters> charList;

        public manager()
        {
            charList = new List<Characters>();
            addInitialData();
        }

        private void addInitialData()
        {
            charList.Add(new King("Stewie"));
            charList.Add(new Queen("Meg"));
            charList.Add(new Knight("Lancelot"));
            charList.Add(new Knight("Irving"));
            charList.Add(new Troll("Grumpy"));
        }

        public List<Characters> CharList
        {
            get
            {
                return charList;
            }

            set
            {
                charList = value;
            }
        }
    }
}
