using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XMLPartical
{
    public partial class Form1 : Form
    {
        private XDocument xdocument;

        public Form1()
        {
            InitializeComponent();
            xdocument = XDocument.Load("pubsAndClubs.xml");
        }

        private List<string[]> getBand()
        {
            List<string[]> gigInfo = new List<string[]>();

            foreach (XElement item in xdocument.Element("Event_Guide").Elements("Gig"))
            {
                string name = item.Element("Band").Element("Name").Value;
                string genre = item.Element("Band").Element("Genre").Value;
                string venue = item.Element("Venue").Value;
                string day = item.Element("Date").Attribute("day").Value;
                string month = item.Element("Date").Attribute("month").Value;
                string year = item.Element("Date").Attribute("year").Value;
                string date = day + "/" + month + "/" + year;
                string time = item.Element("Time").Value;
                string[] info = { name, genre, venue, date, time };
                gigInfo.Add(info);
            }
            return gigInfo;
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            for (int i = 0; i < getBand().Count; i++)
            {
                dataGridView.Rows.Add(getBand()[i]);
            }
        }

        private void btnListHardRock_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            foreach (string[] item in getBand())
            {
                if(item[1] == "\n\t\t\t\tHard Rock\n\t\t\t")
                {
                    dataGridView.Rows.Add(item);
                }
            }
        }

        private void btnCurrentMonth_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            int thisMonth = DateTime.Now.Month;
            foreach (string[] item in getBand())
            {
                int index = item[3].IndexOf('/') + 1;
                int month = Convert.ToInt32(item[3].Substring(index, 2));
                if(month == thisMonth)
                {
                    dataGridView.Rows.Add(item);
                }
            }
        }

        private List<string[]> getBandMember()
        {
            foreach (XElement item in xdocument.Element("Event_Guide").Elements("Gig"))
            {
                XElement band = item.Element("Band");
                string bandName = band.Element("Name").Value; 
                if (bandName == "\n\t\t\t\tAlabama Shakes\n\t\t\t")
                {
                    List<string[]> info = new List<string[]>();
                    foreach (XElement member in band.Element("Band_Members").Elements("Member"))
                    {
                        string name = member.Element("First_Name").Value + member.Element("Last_Name").Value;
                        string instrucments = "";
                        foreach (XElement instrument in member.Elements("Instruments"))
                        {
                            instrucments += instrument.Value + " ";
                        }

                        string role = "";

                        try
                        {
                            role = member.Element("Role").Value;
                        }
                        catch (Exception)
                        {
                            role = "No role";
                        }

                        string[] all = { name, instrucments, role };
                        info.Add(all);                           
                    }
                    return info;
                }
            }
            return null;
        }

        private void btnBandMembers_Click(object sender, EventArgs e)
        {
            if(getBandMember() != null)
            {
                foreach (string[] item in getBandMember())
                {
                    AnotherDataGridView.Rows.Add(item);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            XElement newGig = new XElement("Gig", new XElement("Venue", "New Venue"),
                                                  new XElement("Date", new XAttribute("day", "24"), new XAttribute("month", "11"), new XAttribute("year", "2016")),
                                                  new XElement("Time", "2:30PM"),
                                                  new XElement("Band", 
                                                                      new XElement("Name", "New Band"),
                                                                      new XElement("Genre", "Blues")));
            xdocument.Element("Event_Guide").Add(newGig);
            xdocument.Save("pubsAndClubs.xml");
        }
    }
}
