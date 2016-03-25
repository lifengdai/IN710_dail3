using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Network
{
    class Observer : ISubscriber
    {
        private string status;
        private Mointor mointor;
        private ListBox listbox;

        public Observer(ListBox listbox, Mointor mointor)
        {
            this.mointor = mointor;
            this.listbox = listbox;
            mointor.AddSubscriber(this);
            status = "";
        }

        public void Display()
        {
            DateTime dt = DateTime.Now;
            listbox.Items.Add(dt.ToString());
            listbox.Items.Add(status);
        }

        public void Update<T>(T data)
        {
            status = data.ToString();
        }
    }
}
