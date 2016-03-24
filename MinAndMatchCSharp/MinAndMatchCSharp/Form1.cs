using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinAndMatchCSharp
{
    public partial class Form1 : Form
    {
        private MakeMonstor makemonstor;

        public Form1()
        {
            InitializeComponent();
            makemonstor = new MakeMonstor(cmbxHead, cmbxBody, cmbxLegs);
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            picbxHead.Image = makemonstor.monstor(cmbxHead.SelectedItem.ToString(),
                cmbxBody.SelectedItem.ToString(),
                cmbxLegs.SelectedItem.ToString()
                ).getHead();
            picbxBody.Image = makemonstor.monstor(cmbxHead.SelectedItem.ToString(),
                cmbxBody.SelectedItem.ToString(),
                cmbxLegs.SelectedItem.ToString()
                ).getBody();
            picbxLegs.Image = makemonstor.monstor(cmbxHead.SelectedItem.ToString(),
                cmbxBody.SelectedItem.ToString(),
                cmbxLegs.SelectedItem.ToString()
                ).getLegs();
        }
    }
}
