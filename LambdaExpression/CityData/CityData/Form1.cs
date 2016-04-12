using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityData
{
    public partial class Form1 : Form
    {
        private Cities cities;

        public Form1()
        {
            InitializeComponent();
            cities = new Cities();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string searchBy = textBox.Text;
            Func<string, City> search = new Func<string, City>(name =>
            {
                foreach (City item in cities.CityList)
                {
                    if(name == item.CityName)
                    {
                        return item;
                    }
                }
                return null;
            });
            listBox.Items.Add(search(searchBy).ToString());
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            cities.CityList.ForEach(x => {x.Population *= 3; listBox.Items.Add(x.printPopulation());});
        }
    }
}
