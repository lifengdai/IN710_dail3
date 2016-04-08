using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomHandler
{
    class CustomEventHandler
    {
        private Random rand;
        private Button b;

        public CustomEventHandler(int seed, Button b)
        {
            rand = new Random(seed);
            this.b = b;
            b.Click += new EventHandler(randNum);
        }

        public void randNum(object o, EventArgs e)
        {
            string messgae = "My number is randnum " + rand.Next(100) + "\r\n" + "I'm from custom handler";
            MessageBox.Show(messgae, "Information", MessageBoxButtons.OK);
        }
    }
}
