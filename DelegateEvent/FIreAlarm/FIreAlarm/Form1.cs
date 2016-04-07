using System;
using System.Windows.Forms;

namespace FireAlarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            Publisher publisher = new Publisher();
            BeepSubscriber derek = new BeepSubscriber(publisher);
            InstrctionSubscriber sean = new InstrctionSubscriber(publisher);

            if(rdobtnMinor.Checked)
            {
                publisher.OnfirmEvent(EFires.Minor);
            }
            if(rdobtnSerious.Checked)
            {
                publisher.OnfirmEvent(EFires.Serious);
            }
            if(rdobtnInferno.Checked)
            {
                publisher.OnfirmEvent(EFires.Inferno);
            }
        }
    }
}
