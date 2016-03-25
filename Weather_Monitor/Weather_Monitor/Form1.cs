using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Monitor
{
    public partial class Form1 : Form
    {
        private Manager manager;

        public Form1()
        {
            InitializeComponent();
            manager = new Manager(lstbReadings, lstbAvgReading, lstbForecast);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            manager.UpdateAndDisplay();
        }

        private void txtTemp_TextChanged(object sender, EventArgs e)
        {
            manager.changedData(0, txtTemp.Text);
        }

        private void txtHumidity_TextChanged(object sender, EventArgs e)
        {
            manager.changedData(1, txtHumidity.Text);
        }

        private void txtPressure_TextChanged(object sender, EventArgs e)
        {
            manager.changedData(2, txtPressure.Text);
        }
    }
}
