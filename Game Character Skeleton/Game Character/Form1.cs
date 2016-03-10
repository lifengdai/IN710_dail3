using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public partial class Form1 : Form
    {
        private manager manager;

        public Form1()
        {
            InitializeComponent();
            manager = new manager();
            addInitCharacters();
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            foreach (object item in groupBox1.Controls)
            {
                if(((RadioButton)item).Checked)
                {
                    switch (((RadioButton)item).Text)
                    {
                        case "King":
                            manager.CharList.Add(new King(name));                           
                            break;
                        case "Queen":
                            manager.CharList.Add(new Queen(name));
                            break;
                        case "Knight":
                            manager.CharList.Add(new Knight(name));
                            break;
                        case "Troll":
                            manager.CharList.Add(new Troll(name));
                            break;
                    }
                    checkedListBox1.Items.Add(name);
                    checkedListBox2.Items.Add(name);
                }
            }
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            foreach (string item in checkedListBox1.CheckedItems)
            {
                foreach(Characters charitem in manager.CharList)
                {
                    if(item == charitem.Name)
                    {
                        listBox1.Items.Add(charitem.Says());
                        listBox1.Items.Add(charitem.StateName());
                        listBox1.Items.Add(charitem.useWeapon());
                        listBox1.Items.Add("-----------------------------------");
                    }
                }
            }
        }

        //Not sure this is correct or not
        //Still need switch in here
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string item in checkedListBox2.CheckedItems)
            {
                foreach (Characters charitem in manager.CharList)
                {
                    if (item == charitem.Name)
                    {
                        foreach (object rb in groupBox2.Controls)
                        {
                            if (((RadioButton)rb).Checked)
                            {
                                switch (((RadioButton)rb).Text)
                                {
                                    case "Sword":
                                        charitem.ChangeWeapon(new Sword());
                                        break;
                                    case "Knife":
                                        charitem.ChangeWeapon(new Knife());
                                        break;
                                    case "Bow":
                                        charitem.ChangeWeapon(new Bow());
                                        break;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void addInitCharacters()
        {
            foreach (Characters item in manager.CharList)
            {
                checkedListBox1.Items.Add(item.Name);
                checkedListBox2.Items.Add(item.Name);
            }
        }
    }
}
