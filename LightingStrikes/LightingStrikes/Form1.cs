using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightingStrikes
{
    public partial class Form1 : Form
    {
        private DataClassesDataContext data;

        public Form1()
        {
            InitializeComponent();
            data = new DataClassesDataContext();
        }

        private void btnDisplayIntensity_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            double average = 0;
            IEnumerable<int> intensity = from inten in data.tblStrikes
                                         select inten.strikeIntensity;
            average = intensity.Average();
            listBox.Items.Add(average);
        }

        private void btnListRecords_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            int index = 0;
            var fireArea = from area in data.tblFires
                           orderby area.fireArea descending
                           select area;
            foreach (var item in fireArea)
            {
                index++;
                if (index == 4)
                {
                    break;
                }
                else
                {
                    string id = item.fireID.ToString();
                    string date = item.fireDate.ToLongDateString();
                    string lat = item.fireLatitude.ToString();
                    string lon = item.fireLongitude.ToString();
                    string area = item.fireArea.ToString();
                    string fireInfo = id + "\t\t" + date + "\t\t" + lat + "\t\t" + lon + "\t\t" + area;
                    listBox.Items.Add(fireInfo);
                }
            }
        }

        private void btnDisplayLatLongFilename_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            var displayLatLonFile = from light in data.tblStrikes
                                    join pictue in data.tblPictures
                                    on light.strikeID equals pictue.strikeID
                                    group light by pictue.strikeID;
            foreach (var item in displayLatLonFile)
            {
                foreach (var display in item)
                {
                    string id = display.strikeID.ToString();
                    string lat = display.strikeLatitude.ToString();
                    string lon = display.strikeLongitude.ToString();
                    string filename = "";
                    foreach (var pic in display.tblPictures)
                    {
                        filename = pic.pictureFileName;
                    }
                    string final = id + "\t\t" + lat + "\t\t" + lon + "\t\t" + filename;
                    listBox.Items.Add(final);
                }
            }
        }

        private void btnStrikeCausedFire_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            var causedBylighting = from lightning in data.tblStrikes
                                   from fire in data.tblFires
                                   where lightning.strikeDate == fire.fireDate
                                   && lightning.strikeLatitude == fire.fireLatitude
                                   && lightning.strikeLongitude == fire.fireLongitude
                                   select fire;
            foreach (var item in causedBylighting)
            {
                string display = item.fireID + "\t\t" + item.fireDate + "\t\t"
                    + item.fireLatitude + "\t\t" + item.fireLongitude + "\t\t"
                    + item.fireArea;
                listBox.Items.Add(display);
            }
        }
    }
}
