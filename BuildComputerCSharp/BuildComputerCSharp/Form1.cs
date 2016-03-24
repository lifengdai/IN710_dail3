using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildComputerCSharp
{
    public partial class Form1 : Form
    {
        private Maker maker;

        public Form1()
        {
            InitializeComponent();
            maker = new Maker();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            lstbxShow.Items.Clear();
            if (rdobtnGame.Checked)
            {
                maker.GameComputerAssemblyLine().printToDisplay(lstbxShow);
            }
            if (rdobtnBusiness.Checked)
            {
                maker.BusinessComputerAssemblyLine().printToDisplay(lstbxShow);
            }
            if (rdobtnMultimedia.Checked)
            {
                maker.MultimediaComputerAssemblyLine().printToDisplay(lstbxShow);
            }
        }
    }
}
