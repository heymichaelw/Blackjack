using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Deck
    {
        
        enum CardNames
        {
            Two = 2,
            Three, 
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten = 10,
            Jack = 10,
            Queen = 10,
            King = 10,
            Ace

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
                foreach (var ename in Enum.GetNames(typeof(CardNames)))
                {
                    string name = ename;
                    int value = (int)((CardNames)Enum.Parse(typeof(CardNames), name));
                    cards.Add(new Card(name, suit, value));
                }
            }


            return cards;
            
        }

    }
}
