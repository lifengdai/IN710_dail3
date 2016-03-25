using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Monitor
{
    class ForecastObserver : Observer
    {
        public ForecastObserver(ListBox listbox)
            : base(listbox)
        { }

        public override void Update<T>(int code, T data)
        {
            base.Update<T>(code, data);
        }

        public override void Display()
        {
            listbox.Items.Clear();
            if (currentPre > 101)
            {
                listbox.Items.Add("Sunny day");
            }
            else
            {
                listbox.Items.Add("Rainy day");
            }
        }
    }
}
