using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Deck
    {
        
        public static List<string> CardNames = new List<string>()
        {
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten",
            "Jack",
            "Queen",
            "King",
            "Ace"

        };
        public static List<string> CardSuit = new List<string>() { "Spades", "Hearts", "Diamonds", "Clubs" };
        public static List<Card> cards = new List<Card>();

        public Deck()
        {

        }
        

        public static List<Card> MakeDeck()
        {
            foreach (string suit in CardSuit)
            {
                foreach (string name in CardNames)
                {
                    cards.Add(new Card(name, suit));
                }
            }


            return cards;
            
        }

    }
}
