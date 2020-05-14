using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCard
{
    class PlayingCard
    {
        private int rank;
        private int suit;

        public static int Diamonds = 1;
        public static int Clubs = 2;
        public static int Hearts = 3;
        public static int Spades = 4;

        public static int Ace = 1;
        public static int Deuce = 2;
        public static int Three = 3;
        public static int Four = 4;
        public static int Five = 5;
        public static int Six = 6;
        public static int Seven = 7;
        public static int Eight = 8;
        public static int Nine = 9;
        public static int Ten = 10;
        public static int Jack = 11;
        public static int Queen = 12;
        public static int King = 13;

        public static bool isValidSuit(int suit)
        {
            if ((suit >= Diamonds) && (suit <= Spades))
            {
                Console.WriteLine("Valid suit");
                return true;
            }
            return false;
        }
        public static bool isValidRank(int rank)
        {
            if ((rank >= Ace) && (rank <= King))
            {
                Console.WriteLine("Valid rank");
                return true;
            }
            return false;
        }
        public PlayingCard(int suit, int rank)
        {
            bool okrank = isValidRank(rank);
            bool oksuit = isValidSuit(suit);
            if (okrank == true)
                this.rank = rank;
            else
                Console.WriteLine("Not a valid rank");
            if (oksuit == true)
                this.suit = suit;
            else
                Console.WriteLine("Not a valid suit");


        }
        public int getSuit()
        {
            return suit;
        }
        public int getRank()
        {
            return rank;
        }
        public string RankToString()
        {
            switch (rank)
            {
                case 1: return "Ace";
                case 2: return "Deuce";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight";
                case 9: return "Nine";
                case 10: return "Ten";
                case 11: return "Jack";
                case 12: return "Queen";
                case 13: return "King";
                default: return "Error";
            }
        }
        public string SuitToString()
        {
            switch (suit)
            {
                case 1: return "Diamonds";
                case 2: return "Clubs";
                case 3: return "Hearts";
                case 4: return "Spades";
                default: return "Error";

            }
        }
        public override string ToString()
        {
            return string.Format($"You introduced:{suit}, {rank}, equivalent to ");
        }
    }
}
