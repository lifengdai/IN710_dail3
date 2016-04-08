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
        public delegate void customHandler(object o, EventArgs e);
        public event customHandler handler;
        private Random rand;
        private Button b;

        public CustomEventHandler(Button b)
        {
            rand = new Random();
            this.b = b;
        }

        public void randNum(object o, EventArgs e)
        {
            string messgae = "My number is randnum " + rand.Next(100) + "\r\n" + "I'm from custom handler";
            MessageBox.Show(messgae, "Information", MessageBoxButtons.OK);
        }

        public void OnClick()
        {
            if (handler != null)
                handler(b, new EventArgs());
        }
    }
}
