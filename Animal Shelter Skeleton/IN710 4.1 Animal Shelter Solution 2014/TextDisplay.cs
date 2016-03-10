using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class TextDisplay : IDisplay
    {
        private ListBox lb;

        public TextDisplay(ListBox lb)
        {
            this.lb = lb;
        }

        /* YOUR CODE HERE */
        public void clearDisplay()
        {
            lb.Items.Clear();
        }

        public void displayCritterList(List<Critter> critterList)
        {
            foreach (Critter item in critterList)
            {
                string str = item.Name + " " + item.Species;
                lb.Items.Add(str);
            }
        }
    }
}
