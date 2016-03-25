using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Monitor
{
    class ReadingObserver : Observer
    {
        public ReadingObserver(ListBox listbox)
            : base(listbox)
        { }

        public override void Update<T>(int code, T data)
        {
            base.Update<T>(code, data);
        }

        public override void Display()
        {
            base.Display();
        }
    }
}
