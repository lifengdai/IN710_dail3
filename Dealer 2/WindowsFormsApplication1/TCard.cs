using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class TCard
    {
        private int privateNumber;
        private int privateSuit;

        public int number
        {
            get
            {
                return privateNumber;
            }

            set
            {
                privateNumber = value;
            }
        }

        public int suit
        {
            get
            {
                return privateSuit;
            }

            set
            {
                privateSuit = value;
            }
        }

        public TCard (int number, int suit)
        {
            privateNumber = number;
            privateSuit = suit;
        }

        //public override string ToString()
        //{
        //    String ThisCard = "";

        //    switch (privateNumber)
        //    {
        //        case 14:
        //            ThisCard += "Ace";
        //            break;

        //        case 11:
        //            ThisCard += "Jack";
        //            break;

        //        case 12:
        //            ThisCard += "Queen";
        //            break;

        //        case 13:
        //            ThisCard += "King";
        //            break;

        //        default:
        //            ThisCard += privateNumber;
        //            break;
        //    } 

        //    ThisCard += ": ";

        //    switch (privateSuit)
        //    {
        //        case 0:
        //            ThisCard += "Spades";
        //            break;

        //        case 1:
        //            ThisCard += "Clubs";
        //            break;

        //        case 2:
        //            ThisCard += "Diamonds";
        //            break;

        //        case 3:
        //            ThisCard += "Hearts";
        //            break;
        //    }
        //    return ThisCard + "\r\n";
        //}

        public override string ToString()
        {
            String ThisCard = "";
            ThisCard += privateNumber + " ";
            return ThisCard;
        }
    }
}
