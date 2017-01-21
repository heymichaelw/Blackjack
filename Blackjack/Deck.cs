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
        public static Random rng = new Random();


        public Deck()
        {

        }
        

        public static List<Card> MakeDeck()
        {
            foreach (string suit in CardSuit)
            {
                foreach (var ename in Enum.GetNames(typeof(CardNames)))
                {
                    
                    int value = (int)((CardNames)Enum.Parse(typeof(CardNames), ename));
                    cards.Add(new Card(ename, suit, value));
                }
            }

            int i = cards.Count;
            while(i > 1)
            {
                i--;
                int k = rng.Next(i + 1);
                var value = cards[k];
                cards[k] = cards[i];
                cards[i] = value;

            }

            return cards; 
            
             
        }

        

    }
}
