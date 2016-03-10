using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encryptioon
{
    public partial class Form1 : Form
    {
        private Parser parser;

        public Form1()
        {
            InitializeComponent();
            parser = new Parser();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            encrypt();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            encrypt();
        }

        private void encrypt()
        {
            if(rbROT13.Checked)
            {
                parser.EncryptionMachine = new Rot13();
                txtOutput.Text = parser.Encrypt(txtInput.Text);           
            }
            else
            {
                parser.EncryptionMachine = new Reverse();
                txtOutput.Text = parser.Encrypt(txtInput.Text);
            }
        }
    }
}
