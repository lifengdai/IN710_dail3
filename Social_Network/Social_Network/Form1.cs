using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Network
{
    public partial class Form1 : Form
    {
        private Manager manager;

        public Form1()
        {
            InitializeComponent();
            manager = new Manager();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            manager.UpdateAndDisplay(txtStatus.Text);
            lstbxMe.Items.Add(txtStatus.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            manager.CreateFiveFriends(lstbxFriend1);
            manager.CreateFiveFriends(lstbxFriend2);
            manager.CreateFiveFriends(lstbxFriend3);
            manager.CreateFiveFriends(lstbxFriend4);
        }
    }
}
