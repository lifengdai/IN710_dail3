using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_and_Exception_Handling
{
    class Movie
    {
        private string movieName;
        private string movieDirector;
        private int movieYear;

        public Movie(int movieYear, string movieName, string movieDirector)
        {
            this.movieYear = movieYear;
            this.movieName = movieName;
            this.movieDirector = movieDirector;
        }

        public override string ToString()
        {
            string year = "Year: " + movieYear + "   \r\n";
            string title = "Title: " + movieName + "   \r\n";
            string director = "Director: " + movieDirector + "   \r\n";

            return year + title + director;
        }

        public string MovieName
        {
            get { return "Title: " + movieName; }
            set { movieName = value; }
        }

        public string MovieDirector
        {
            get { return "Director: " + movieDirector; }
            set { movieDirector = value; }
        }

        public int MovieYear
        {
            get { return movieYear; }
            set { movieYear = value; }
        }

        public string Year()
        {
            return "Year: " + movieYear;
        }
    }
}
