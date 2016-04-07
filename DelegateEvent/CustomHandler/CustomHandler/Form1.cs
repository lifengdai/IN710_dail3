using System;
using System.Windows.Forms;

namespace CustomHandler
{
    public partial class Form1 : Form
    {
        private CustomEventHandler eh;

        public Form1()
        {
            InitializeComponent();
            eh = new CustomEventHandler(btnTest);
            eh.handler += new CustomEventHandler.customHandler(eh.randNum);
            eh.handler += new CustomEventHandler.customHandler(eh.randNum);          
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is my form's handler");
        }

        private void btnTest_MouseClick(object sender, MouseEventArgs e)
        {
            eh.OnClick();
        }
    }
}
