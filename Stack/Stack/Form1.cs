using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack
{
    //This basicly is the test class
    public partial class StackForm : Form
    {
        private MyStack<string> ms;
        private Random rand;

        public StackForm()
        {
            InitializeComponent();

            ms = new MyStack<string>();
            rand = new Random();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string s = rand.Next(0, 100).ToString();
            ms.Push(s);
            tbShowAdded.Text = s;
        }

        //Will crash if no element in it
        //It should crash in this case
        private void btnPeek_Click(object sender, EventArgs e)
        {
            tbShowLastValue.Text = ms.Peek();
        }

        //Will crash if no element in it
        //It should crash in this case
        private void btnPop_Click(object sender, EventArgs e)
        {
            tbShowLastValueRemove.Text = ms.Pop();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            tbCount.Text = ms.Count().ToString();
        }

        private void btnIsEmpty_Click(object sender, EventArgs e)
        {
            tbIsEmpty.Text = ms.isEmpty().ToString();
        }

        //Test foreach loop works for MyGenericList or not
        private void btnTestIEmu_Click(object sender, EventArgs e)
        {
            lbTestIEmu.Items.Clear();
            foreach (string item in ms.Mgl)
            {
                lbTestIEmu.Items.Add(item);
            }
        }
    }
}
