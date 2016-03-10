using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class PictureDisplay : IDisplay
    {
        private List<PictureBox> listOfPictureBox;

        public PictureDisplay(List<PictureBox> listOfPictureBox)
        {
            this.listOfPictureBox = listOfPictureBox;
        }

        /* YOUR CODE HERE */
        public void clearDisplay()
        {
            foreach (PictureBox item in listOfPictureBox)
            {
                item.Image = null;
            }
        }

        public void displayCritterList(List<Critter> critterList)
        {
            for (int i = 0; i < critterList.Count; i++)
            {
                listOfPictureBox[i].Image = Image.FromFile(critterList[i].ImageFileName);
            }
        }
    }
}
