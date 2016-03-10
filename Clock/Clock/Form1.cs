using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        private Choser choser;

        public Form1()
        {
            InitializeComponent();
            choser = new Choser(analogClock);
        }

        private void btnStartClock_Click(object sender, EventArgs e)
        {
            choser.On();
        }

        private void btnStopClock_Click(object sender, EventArgs e)
        {
            choser.Off();
        }

        private void rbDigital_CheckedChanged(object sender, EventArgs e)
        {
            if(((RadioButton)sender).Checked)
            {
                choser.HideClock();
                choser.Clock = new Digital(lblDigitalClock, timer1);
                choser.ShowClock();
            }
            else
            {
                choser.HideClock();
                choser.Clock = new Analogue(analogClock);
                choser.ShowClock();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(rbDigital.Checked)
            {
                choser.UpdateTimeDisplay();
            }
        }
    }
}
