using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Monitor
{
    public class Manager
    {
        private TempMointer temp;
        private HumidityMointor hum;
        private PreMointor pre;
        private ReadingObserver readingob;
        private AvgReading avgob;
        private ForecastObserver fc;

        public Manager(ListBox reading, ListBox average, ListBox cast)
        {
            temp = new TempMointer();
            hum = new HumidityMointor();
            pre = new PreMointor();
            readingob = new ReadingObserver(reading);
            avgob = new AvgReading(average);
            fc = new ForecastObserver(cast);
            readingob.Register(temp);
            avgob.Register(temp);
            fc.Register(temp);
            readingob.Register(hum);
            avgob.Register(hum);
            fc.Register(hum);
            readingob.Register(pre);
            avgob.Register(pre);
            fc.Register(pre);
        }

        public void changedData(int code, string data)
        {
            if ((data != "") && (data != null))
            {
                switch (code)
                {
                    case 0:
                        temp.CurrectTemp = Convert.ToDouble(data);
                        break;
                    case 1:
                        hum.CurrentHumidity = Convert.ToDouble(data);
                        break;
                    case 2:
                        pre.CurrentPressure = Convert.ToDouble(data);
                        break;
                }
            }       
        }

        public void UpdateAndDisplay()
        {
            temp.NotifySubscriber();
            hum.NotifySubscriber();
            pre.NotifySubscriber();
            readingob.Display();
            avgob.Display();
            fc.Display();
        }
    }
}
