using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bicycle_DashBoard_CSharp
{
    public partial class Form1 : Form
    {
        private BicycleMointor bicycle;
        private Observer observer;
        private CPHObserver cph;
        private KPHObserver kph;

        public Form1()
        {
            InitializeComponent();
            bicycle = new BicycleMointor();
            observer = new Observer(lblRPM, bicycle);
            cph = new CPHObserver(lblCPH, bicycle);
            kph = new KPHObserver(lblKPH, bicycle);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bicycle.CurrentRPM = Convert.ToInt32(txtSpeed.Text);
            bicycle.NotifySubscriber();
            observer.Display();
            cph.Display();
            kph.Display();
        }
    }
}
