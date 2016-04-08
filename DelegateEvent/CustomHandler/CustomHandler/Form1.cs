using System;
using System.Windows.Forms;

namespace CustomHandler
{
    public partial class Form1 : Form
    {
        private CustomEventHandler eh;
        private CustomEventHandler evh;

        public Form1()
        {
            InitializeComponent();
            eh = new CustomEventHandler(10, btnTest);
            evh = new CustomEventHandler(15, btnTest);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is my form's handler");
        }
    }
}
