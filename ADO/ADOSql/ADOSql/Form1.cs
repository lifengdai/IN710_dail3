using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListPapers_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            for (int i = 0; i < TalkToDatebase.Allpaper().Item1.Count; i++)
            {
                string print = TalkToDatebase.Allpaper().Item1[i] + "\t\t" + TalkToDatebase.Allpaper().Item2[i];
                listBox.Items.Add(print);
            }
        }

        private void btnListDue_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            for (int i = 0; i < TalkToDatebase.DueToNextTwoWeeks().Item1.Count; i++)
            {
                string print = TalkToDatebase.DueToNextTwoWeeks().Item1[i] + "\t\t" + TalkToDatebase.DueToNextTwoWeeks().Item2[i] +
                               "\t\t" + TalkToDatebase.DueToNextTwoWeeks().Item3[i] + "\t\t" + TalkToDatebase.DueToNextTwoWeeks().Item4[i];
                listBox.Items.Add(print);
            }
        }

        private void btnListAverageMark_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            for (int i = 0; i < TalkToDatebase.AverageMark().Count; i++)
            {
                string print = TalkToDatebase.AverageMark()[i].Item1 + "\t\t" + TalkToDatebase.AverageMark()[i].Item2;
                listBox.Items.Add(print);
            }
        }
    }
}
