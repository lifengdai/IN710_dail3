using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garden
{
    class GardenManager
    {
        private List<Garden> listOfGarden;

        public GardenManager()
        {
            listOfGarden = new List<Garden>();
        }

        public void AddGarden(Garden garden)
        {
            listOfGarden.Add(garden);
        }

        public List<Garden> ListOfGarden
        {
            get
            {
                return listOfGarden;
            }
        }

        public string reportArea(Garden garden)
        {
            return string.Format("{0,-14}:{1,8:f2}", garden.OwnerName, garden.GetArea());
        }

        public string reportBalance(Garden garden)
        {
            return string.Format("{0,-14}:{1,8:f2}", garden.OwnerName, garden.GetAccountBalance());
        }
    }
}
