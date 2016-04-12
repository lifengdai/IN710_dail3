using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityData
{
    class City
    {
        private string cityName;
        private string countryName;
        private int population;

        public City(string cityName, string countryName, int population)
        {
            this.cityName = cityName;
            this.countryName = countryName;
            this.population = population;
        }

        public override string ToString()
        {
            return "City Name: " + cityName + " "+ "Country Name: " + countryName + " "+ "Population: " + population;
        }

        public string printPopulation()
        {
            return "City Name: " + cityName + " " + "Population: " + population;
        }

        public string CityName
        {
            get
            {
                return cityName;
            }

            set
            {
                cityName = value;
            }
        }

        public string CountryName
        {
            get
            {
                return countryName;
            }

            set
            {
                countryName = value;
            }
        }

        public int Population
        {
            get
            {
                return population;
            }

            set
            {
                population = value;
            }
        }
    }
}
