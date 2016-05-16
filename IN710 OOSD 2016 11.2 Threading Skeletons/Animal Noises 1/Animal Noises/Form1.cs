using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Animal_Noises
{
    public partial class Form1 : Form
    {
        private Thread t;
        private Animal mainAnimal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainAnimal = new Animal();
            t = new Thread(mainAnimal.speak);
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            t.Start();
        }

        private void btnWhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It is a frog");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            t.Abort();
        }
    }
}
