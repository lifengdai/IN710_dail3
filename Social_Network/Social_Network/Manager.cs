using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Network
{
    class Manager
    {
        private Mointor mointor;

        public Manager()
        {
            mointor = new Mointor();
        }

        public void CreateFiveFriends(ListBox l)
        {
            Observer friend1 = new Observer(l, mointor);
        }

        public void UpdateAndDisplay(string status)
        {
            mointor.Status = status;
            mointor.NotifySubscriber();
            foreach (Observer item in mointor.ObserverList)
            {
                item.Display();
            }
        }
    }
}
