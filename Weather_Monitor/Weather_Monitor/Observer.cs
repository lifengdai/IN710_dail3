using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Monitor
{
    class Observer : ISubscriber
    {
        protected ListBox listbox;
        protected double currentTemp;
        protected double currentHum;
        protected double currentPre;

        public Observer(ListBox listbox)
        {
            this.listbox = listbox;
            currentTemp = 0.0;
            currentHum = 0.0;
            currentPre = 0.0;
        }

        public virtual void Display()
        {
            listbox.Items.Clear();
            string temp = "Temperature: " + currentTemp.ToString("F2") + "C";
            string hum = "Humidity: " + currentHum.ToString("F2") + "%";
            string pre = "Pressure: " + currentPre.ToString("F2") + "KPa";
            listbox.Items.Add(temp);
            listbox.Items.Add(hum);
            listbox.Items.Add(pre);
        }

        public void Register(Mointor mointor)
        {
            mointor.AddSubscriber(this);
        }

        public virtual void Update<T>(int code, T data)
        {
            switch (code)
            {
                case 0:
                    currentTemp = Convert.ToDouble(data);
                    break;
                case 1:
                    currentHum = Convert.ToDouble(data);
                    break;
                case 2:
                    currentPre = Convert.ToDouble(data);
                    break;
            }
        }
    }
}
