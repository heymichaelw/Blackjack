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

            //checking if hand contains an ace
            if (handValue.Contains(11))
            {
                foreach (Card card in Player.hand)
                {
                    Console.WriteLine($"{card.name} of {card.suit}");
                }
                Console.WriteLine("Do you want the Ace to be worth 1 or 11 points?");
                int ace = int.Parse(Console.ReadLine());
                if (ace == 1)
                {
                    handvalue = (handValue.Sum()) - 10;
                    return handvalue;
                }
                else
                {
                    handvalue = handValue.Sum();
                    return handvalue;
                }

            }
            else
            {
                handvalue = handValue.Sum();
                return handvalue;
            }
        }

        public static void GetHand()
        {
            GetHandValue();
            foreach (Card card in Player.hand)
            {
                Console.WriteLine($"{card.name} of {card.suit}");
            }
            Console.WriteLine($"Value : {handvalue}");
        }


    }
}
