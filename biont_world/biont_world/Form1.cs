using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biont_world
{
    public partial class Form1 : Form
    {
        private const int NZL_TYPES = 5;
        private const int ASIA_TYPES = 3;

        private Continent con;
        private Random rand;
        private Graphics graphics;

        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();
            rand = new Random();
        }

        private void btnNewZealand_Click(object sender, EventArgs e)
        {
            con = new NewZealand(lstbxdisplaybox, rand, NZL_TYPES, graphics);
            con.run();
        }

        private void btnAsia_Click(object sender, EventArgs e)
        {
            con = new Asia(lstbxdisplaybox, rand, ASIA_TYPES, graphics);
            con.run();
        }
    }
}
