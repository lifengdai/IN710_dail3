using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Monitor
{
    class AvgReading : Observer
    {
        private List<double> temps;
        private List<double> hums;
        private List<double> pres;
        private double TempArg;
        private double HumArg;
        private double preArg;

        public AvgReading(ListBox listbox)
            : base(listbox)
        {
            TempArg = 0.0;
            HumArg = 0.0;
            preArg = 0.0;
            temps = new List<double>();
            hums = new List<double>();
            pres = new List<double>();
        }

        public override void Update<T>(int code,T data)
        {
            double totalTemp = 0;
            double totalHums = 0;
            double totalPres = 0;

            switch (code)
            {
                case 0:
                    temps.Add(Convert.ToDouble(data));
                    break;
                case 1:
                    hums.Add(Convert.ToDouble(data));
                    break;
                case 2:
                    pres.Add(Convert.ToDouble(data));
                    break;
            }

            for (int i = 0; i < temps.Count; i++)
            {
                totalTemp += temps[i];
            }

            for (int i = 0; i < hums.Count; i++)
            {
                totalHums += hums[i];
            }

            for (int i = 0; i < pres.Count; i++)
            {
                totalPres += pres[i];
            }

            TempArg = totalTemp / temps.Count;
            HumArg = totalHums / hums.Count;
            preArg = totalPres / pres.Count;
        }

        public override void Display()
        {
            listbox.Items.Clear();
            string temp = "Temperature: " + TempArg.ToString("F2") + "C";
            string hum = "Humidity: " + HumArg.ToString("F2") + "%";
            string pre = "Pressure: " + preArg.ToString("F2") + "KPa";
            listbox.Items.Add(temp);
            listbox.Items.Add(hum);
            listbox.Items.Add(pre);
        }
    }
}
