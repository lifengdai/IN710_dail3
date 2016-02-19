using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class THand
    {
        private TCard[] cards;
        private int privatePoints;
        private int numCards;

        private string spades;
        private string hearts;
        private string damonts;
        private string clubs;

        public int points
        {
            get
            {
                return privatePoints;
            }

            set
            {
                privatePoints = value;
            }
        }

        public THand()
        {
            cards = new TCard[13];

            spades = "S:\t";
            hearts = "H:\t";
            damonts = "D:\t";
            clubs = "C:\t";
        }

        public THand(TCard[] cardArray)
        {
            cards = new TCard[13];

            for (int i = 0; i < 13; i++)
            {
                cards[i] = cardArray[i];
            }
        }

        public void addCard(TCard newCard)
        {
            cards[numCards++] = newCard;
        }

        public int calcPoints()
        {
            privatePoints = 0;
            for (int i = 0; i < cards.Length; i++)
            {
                switch (cards[i].number)
                {
                    case 14:
                        privatePoints += 4;
                        break;

                    case 11:
                        privatePoints += 1;
                        break;

                    case 12:
                        privatePoints += 2;
                        break;

                    case 13:
                        privatePoints += 3;
                        break;
                }
            }

            return privatePoints;
        }

        public void sortHand()
        {
            for (int i = 0; i < cards.Length; i++)
            {
                TCard minCard = cards[i];
                int minPos = i;
                for (int j = i; j < cards.Length; j++)
                {
                    if (cards[j].suit < minCard.suit)
                    {
                        minCard = cards[j];
                        minPos = j;
                    }
                    else if (cards[j].suit == minCard.suit)
                    {
                        if (cards[j].number < minCard.number)
                        {
                            minCard = cards[j];
                            minPos = j;
                        }
                    }
                }
                TCard tempCard = cards[minPos];
                cards[minPos] = cards[i];
                cards[i] = tempCard;
            }
        }

        //public override string ToString()
        //{
        //    String myHand = "";
        //    for (int i = 0; i < 13; i++)
        //    {
        //        myHand += cards[i].ToString();
        //    }

        //    return myHand + "\r\n";
        //}

        public string CheckToSort(List<string> needToSort)
        {
            string returnstring = "";


            switch (needToSort.Count)
            {
                case 0:
                    break;

                case 1:
                    returnstring = needToSort[0];
                    break;

                default:
                    returnstring = sort(needToSort);
                    break;
            }

            return returnstring;
        }

        private string sort(List<string> s)
        {
            string t = "";
            List<int> temp = convert(s);

            int tempnum = 0;

            for (int i = 0; i < s.Count; i++)
            {
                for (int j = 0; j < s.Count - 1; j++)
                {
                    if (temp[j] > temp[j+1])
                    {
                        tempnum = temp[j];
                        temp[j] = temp[j + 1];
                        temp[j + 1] = tempnum;
                    }
                }
            }

            foreach (string item in findandreplace(convert(temp)))
            {
                t += item + " ";
            }

            return t;
        }

        private List<int> convert(List<string> needtoconvert)
        {
            List<int> temp = new List<int>();
            foreach (string item in needtoconvert)
            {
                temp.Add(Convert.ToInt32(item));
            }
            return temp;
        }

        private List<string> convert(List<int> needtoconvert)
        {
            List<string> temp = new List<string>();
            foreach (int item in needtoconvert)
            {
                temp.Add(Convert.ToString(item));
            }
            return temp;
        }

        private List<string> findandreplace(List<string> s)
        {
            for (int i = 0; i < s.Count; i++)
            {
                switch (s[i])
                {
                    case "10":
                        s[i] = "T";
                        break;

                    case "11":
                        s[i] = "J";
                        break;

                    case "12":
                        s[i] = "Q";
                        break;

                    case "13":
                        s[i] = "K";
                        break;

                    case "14":
                        s[i] = "A";
                        break;
                }
            }
            return s;
        }

        public override string ToString()
        {
            string myhand = "";

            List<string> Stemp = new List<string>();
            List<string> Htemp = new List<string>();
            List<string> Dtemp = new List<string>();
            List<string> Ctemp = new List<string>();

            for (int i = 0; i < 13; i++)
            {
                switch(cards[i].suit)
                {
                    case 0:
                        //spades += cards[i].ToString();
                        Stemp.Add(cards[i].ToString());
                        break;
                    case 1:
                        //hearts += cards[i].ToString();
                        Htemp.Add(cards[i].ToString());
                        break;
                    case 2:
                        //damonts += cards[i].ToString();
                        Dtemp.Add(cards[i].ToString());
                        break;
                    case 3:
                        //clubs += cards[i].ToString();
                        Ctemp.Add(cards[i].ToString());
                        break;
                }
            }
            return myhand + spades + CheckToSort(Stemp) + "\r\n" + hearts + CheckToSort(Htemp) + "\r\n" + damonts + CheckToSort(Dtemp) + "\r\n" + clubs + CheckToSort(Ctemp) + "\r\n";
        }
    }
}
