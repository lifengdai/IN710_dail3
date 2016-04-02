using System;
using System.Windows.Forms;

namespace Predicate
{
    public partial class Form1 : Form
    {
        private DealWithNumbers dealWithNumbers;

        public Form1()
        {
            InitializeComponent();
            dealWithNumbers = new DealWithNumbers();
        }

        private void writeToScreen(Predicate<int> p, ListBox listbox)
        {
            listbox.Items.Clear();
            foreach (int num in dealWithNumbers.Numbers)
            {              
                if (p(num))
                {
                    listbox.Items.Add(num);
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            dealWithNumbers.generateNumbers(lstbxRandomNumber);
        }

        private void btnSelectEven_Click(object sender, EventArgs e)
        {
            writeToScreen(new Predicate<int>(CheckConditionNumber.isEvenNumber), lstbxResult);
        }

        private void btnSelectLessTen_Click(object sender, EventArgs e)
        {
            writeToScreen(new Predicate<int>(CheckConditionNumber.isLessThenTen), lstbxResult);
        }
    }
}
