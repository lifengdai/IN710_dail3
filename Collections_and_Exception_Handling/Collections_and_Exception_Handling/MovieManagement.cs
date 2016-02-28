using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_and_Exception_Handling
{
    //I should've sperate this class into two classes
    //and put error checking into a sperate class
    class MovieManagement
    {
        private static Dictionary<int, Movie> movieDatabase = new Dictionary<int,Movie>();

        private static Movie movie1 = new Movie(1961, "West SideStory", "Jerome Robbins");
        private static Movie movie2 = new Movie(1972, "The Godfather", "Francis Ford Coppola");
        private static Movie movie3 = new Movie(1984, "Amadeus", "Milos Forman");
        private static Movie movie4 = new Movie(2007, "No Country for Old Men", "Ethan & Joel Coen");

        private const int VAILDDIGIT = 4;
        private static char[] SPECIALCHAR = {'!', '@', '#', '$', '%', '^', '*', '(', ')', '`', '~', '-', '+', '=', ';','|','/','?','<','>',',','.','\'','\\','\"'};
        private static char[] NUMBERCHAR = {'0','1','2','3','4','5','6','7','8','9'};
        private const int TITLE = 0;
        private const int SPACEPOSITION = 0;
        private const int EMPTY = 0;
        private const int NOTEMPTY = 1;
        private const int DRECTOR = 1;
        private const int ERRORINYEAR = 1;
        private const int ERRORINTITLE = 2;
        private const int ERRORDIRECTOR = 3;
        private const int ERRORINYEARANDTITLE = 4;
        private const int ERRORINYEARANDDIRECTOR = 5;
        private const int ERRORINTITLEANDDIRECTOR = 6;
        private const int ERRORINYEARTITLEDIRECTOR = 7;
        private const int ERRORARGUMENTEX = 8;
        private const int FOUND = 0;
        private const int NONE = 0;

        private enum errorCode
        {
            NOSTRING = -1,
            NOTANUMBER = -1,
            EMPTYSTRING = 0,
            SUCCESS = 0,
            TOOSHORT = 1,
            NOTFUND = 1,
            SPECIALCHARFORTITLE = 1,
            SPECIALCHARFORDIRECTOR = 2,
            EMPTYDICTORY = 2,
            STARTWITHSPACE = 3,
            TOOLONG = 2
        }

        public static void addInitMovie()
        {
            movieDatabase.Add(movie1.MovieYear, movie1);
            movieDatabase.Add(movie2.MovieYear, movie2);
            movieDatabase.Add(movie3.MovieYear, movie3);
            movieDatabase.Add(movie4.MovieYear, movie4);
        }

        private static int checkVaildYear(string year)
        {
            int iyear = 0;

            //Check if it is 4 digit
            //If less than 4 return 1
            //If greater than 4 return 2
            //If it's 0 than return 0
            //if equal 4 than check convertability
            //If it is not a number than return -1
            //else return the number

            if (year.Length == (int)errorCode.EMPTYSTRING)
            {
                return  (int)errorCode.EMPTYSTRING;
            }
            else if(!Int32.TryParse(year, out iyear))
            {
                return (int)errorCode.NOTANUMBER;
            }
            else if (year.IndexOf(' ') == SPACEPOSITION)
            {
                return (int)errorCode.STARTWITHSPACE;
            }
            else if ((year.Length < VAILDDIGIT) && (year.Length > (int)errorCode.EMPTYSTRING))
            {
                return (int)errorCode.TOOSHORT;
            }
            else if (year.Length > VAILDDIGIT)
            {
                return (int)errorCode.TOOLONG;
            }
            else
            {
                return iyear;
            }
        }

        private static int vaildString(int tod, string s)
        {
            if (s.Length == (int)errorCode.EMPTYSTRING)
            {
                return (int)errorCode.NOSTRING;
            }
            else if (s.IndexOf(' ') == SPACEPOSITION)
            {
                return (int)errorCode.STARTWITHSPACE;
            }
            else if(tod == TITLE)
            {
                if(chekSpecialChar(s))
                {
                    return (int)errorCode.SPECIALCHARFORTITLE;
                }
                else
                {
                    return (int)errorCode.SUCCESS;
                }
            }
            else
            {
                if ((!chekSpecialChar(s)) && (!checkCharNum(s)))
                {
                    return (int)errorCode.SUCCESS;
                }
                else
                {
                    return (int)errorCode.SPECIALCHARFORDIRECTOR;
                }
            }
        }

        private static bool chekSpecialChar(string s)
        {
            for (int i = 0; i < SPECIALCHAR.Length; i++)
            {
                if (s.Contains(SPECIALCHAR[i]))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool checkCharNum(string s)
        {
            for (int i = 0; i < NUMBERCHAR.Length; i++)
            {
                if (s.Contains(NUMBERCHAR[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static Tuple<int, string> CreateMovie(string year, string title, string director)
        {
            string message = "";
            int iyear = checkVaildYear(year);
            int ititle = vaildString(TITLE, title);
            int idirector = vaildString(DRECTOR, director);
            bool vaildYear = false;
            bool vaildTitle = false;
            bool vaildDirector = false;

            //Check before create
            switch (iyear)
            {
                case (int)errorCode.EMPTYSTRING:
                    message += "Year field is empty \r\n";
                    break;
                case (int)errorCode.NOTANUMBER:
                    message += "It's not a number \r\n";
                    break;
                case (int)errorCode.TOOSHORT:
                    message += "The number is too short, has to be 4 digit \r\n";
                    break;
                case (int)errorCode.TOOLONG:
                    message += "The number is too long, has to be 4 digit \r\n";
                    break;
                case (int)errorCode.STARTWITHSPACE:
                    message += "Can't start with a SPACE\r\n";
                    break;
                default:
                    vaildYear = true;
                    break;
            }

            switch (ititle)
            {
                case (int)errorCode.NOSTRING:
                    message += "Title field is empty \r\n";
                    break;

                case (int)errorCode.SPECIALCHARFORTITLE:
                    message += "Title field contain a SPECIAL charactor \r\n";
                    break;

                case (int)errorCode.STARTWITHSPACE:
                    message += "Can't start with SPACE charactor \r\n";
                    break;

                default:
                    vaildTitle = true;
                    break;
            }

            switch (idirector)
            {
                case (int)errorCode.NOSTRING:
                    message += "Director field is empty \r\n";
                    break;

                case (int)errorCode.SPECIALCHARFORDIRECTOR:
                    message += "Director field contain a SPECIAL charactor \r\n";
                    break;

                case (int)errorCode.STARTWITHSPACE:
                    message += "Can't start with SPACE charactor \r\n";
                    break;

                default:
                    vaildDirector = true;
                    break;
            }

            int errorCodeForCreate = wahtErrorCodeReturn(vaildYear, vaildTitle, vaildDirector);

            if (errorCodeForCreate != (int)errorCode.SUCCESS)
            {
                return Tuple.Create<int, string>(errorCodeForCreate, message);
            }
            else
            {
                try
                {
                    Movie movie = new Movie(iyear, title, director);
                    movieDatabase.Add(iyear, movie);
                    return Tuple.Create<int, string>((int)errorCode.SUCCESS, "Success");
                }
                catch (Exception)
                {
                    message += "Can't have two movies in the same year \r\n";
                    return Tuple.Create<int, string>(ERRORARGUMENTEX, message);
                }
            }
        }

        private static int wahtErrorCodeReturn(bool y, bool t, bool d)
        {
            if(y)
            {
                if(t)
                {
                    if(d)
                    {
                        return (int)errorCode.SUCCESS;
                    }
                    else
                    {
                        return ERRORDIRECTOR;
                    }
                }
                else
                {
                    if (d)
                    {
                        return ERRORINTITLE;
                    }
                    else
                    {
                        return ERRORINTITLEANDDIRECTOR;
                    }
                }
            }
            else
            {
                if (t)
                {
                    if (d)
                    {
                        return ERRORINYEAR;
                    }
                    else
                    {
                        return ERRORINYEARANDDIRECTOR;
                    }
                }
                else
                {
                    if (d)
                    {
                        return ERRORINYEARANDTITLE;
                    }
                    else
                    {
                        return ERRORINYEARTITLEDIRECTOR;
                    }
                }
            }
        }

        public static Tuple<int, Movie> trySearchMovie(string year, out string s)
        {
            try
            {
                int iyear = Convert.ToInt32(year);

                if (checkVaildYear(year) != iyear)
                {
                    s = "Invaild input";
                    return Tuple.Create<int, Movie>((int)errorCode.NOTANUMBER, null);
                }
                else if (movieDatabase.Count == NONE)
                {
                    s = "Database is empty";
                    return Tuple.Create<int, Movie>((int)errorCode.EMPTYDICTORY, null);
                }
                else
                {
                    foreach (KeyValuePair<int, Movie> item in movieDatabase)
                    {
                        if (item.Key == iyear)
                        {
                            s = item.Value.ToString();
                            return Tuple.Create<int, Movie>(FOUND, item.Value);
                        }
                    }
                    s = "Not found";
                    return Tuple.Create<int, Movie>((int)errorCode.NOTFUND, null);
                }
            }
            catch(Exception)
            {
                s = "Check your input";
                return Tuple.Create<int, Movie>((int)errorCode.NOTANUMBER, null);
            }
        }

        public static void deleteMovie(string year)
        {
            movieDatabase.Remove(Convert.ToInt32(year));
        }

        public static Tuple<int, string> checkDeleteMovie(string year)
        {
            string s = "";
            Tuple<int, Movie> result = trySearchMovie(year, out s);
            if(result.Item1 == FOUND)
            {
                return Tuple.Create<int, string>(FOUND, s + "--------------------------------------\r\nAre you sure to DELETE?");
            }
            else
            {
                return Tuple.Create<int, string>((int)errorCode.NOTFUND, s);
            }
        }

        public static Tuple<int, List<string>> print()
        {
            List<string> everything = new List<string>();
            if(movieDatabase.Count == EMPTY)
            {
                everything.Add("Nothing in the database");
                return Tuple.Create<int, List<string>>(EMPTY, everything);
            }
            else
            {
                foreach (KeyValuePair<int,Movie> item in movieDatabase)
                {
                    everything.Add(item.Value.Year());
                    everything.Add(item.Value.MovieName);
                    everything.Add(item.Value.MovieDirector);
                    everything.Add("---------------------------------");
                }
                return Tuple.Create<int, List<string>>(NOTEMPTY, everything);
            }
        }
    }
}
