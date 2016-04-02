using System;
using System.Windows.Forms;

namespace Garden
{
    public partial class Form1 : Form
    {
        private GardenManager gardenManager;
        private delegate string reporter(Garden garden);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gardenManager = new GardenManager();
            populateDummyData();
        }

        private void populateDummyData()
        {
            Garden garden1 = new Garden(10, 20, "Savitch");
            garden1.AddCharge(123.45);
            garden1.AddCharge(678.90);

            Garden garden2 = new Garden(8.5, 120, "Knuth");
            garden2.AddCharge(45.32);
            garden2.AddCharge(678.90);
            garden2.AddCharge(98.76);

            Garden garden3 = new Garden(54.25, 60, "Winograd");
            garden3.AddCharge(149.32);
            garden3.AddCharge(78.12);
            garden3.AddCharge(150.00);

            gardenManager.AddGarden(garden1);
            gardenManager.AddGarden(garden2);
            gardenManager.AddGarden(garden3);
        }

        private void ProcessGarden(reporter r)
        {
            listBox1.Items.Clear();
            foreach (Garden garden in gardenManager.ListOfGarden)
            {
                listBox1.Items.Add(r(garden));
            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            /* YOUR CODE HERE */
            reporter report = new reporter(gardenManager.reportArea);
            ProcessGarden(report);
        }

        private void btnCharges_Click(object sender, EventArgs e)
        {
            /* YOUR CODE HERE */
            reporter report = new reporter(gardenManager.reportBalance);
            ProcessGarden(report);
        }
    }
}
