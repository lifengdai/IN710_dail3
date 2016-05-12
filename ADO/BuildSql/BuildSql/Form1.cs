using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {           
            TalkToSql.CreateTables();
            TalkToSql.Insert();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            TalkToSql.CloseConnection();
        }

        private void btnDropConstraint_Click(object sender, EventArgs e)
        {
            TalkToSql.DropConstraint();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            TalkToSql.ConnectToBitDev();
        }
    }
}
