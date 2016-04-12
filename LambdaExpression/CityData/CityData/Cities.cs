using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityData
{
    class Cities
    {
        private List<City> cityList;

        public Cities()
        {
            cityList = new List<City>();
            populateCities();
        }

        private void populateCities()
        {
            cityList.Add(new City("Dunedin", "New Zealand", 100000));
            cityList.Add(new City("Centerview", "USA", 23300));
            cityList.Add(new City("Borum", "Sweden", 12000));
            cityList.Add(new City("Pozohondo", "Spain", 21300));
            cityList.Add(new City("Busnela", "Spain", 32000));
        }
        
        public List<City> CityList
        {
            get
            {
                return cityList;
            }

            set
            {
                cityList = value;
            }
        }
    }
}
