using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Player
    {
        public static List<Card> hand = new List<Card>();
        public static List<int> handValue = new List<int>();
        public static int handvalue;

        public Player()
        {

        }

        public static int GetHandValue()
        {
            foreach (Card card in Player.hand)
            {
                handValue.Add(card.value);
            }
            handvalue = handValue.Sum();
            return handvalue;
        }



    }
}
