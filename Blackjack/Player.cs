using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Player
    {
        public static List<Card> playerhand = new List<Card>();
        public static List<Card> dealerhand = new List<Card>();
        public static List<int> handValue = new List<int>();
        public static List<int> dealerhandvalue = new List<int>();
        public static int dealervalue;
        public static int handvalue;
        public static Random rng = new Random();

        public Player()
        {

        }



        public static int GetHandValue()
        {
            handValue.Clear();
            foreach (Card card in Player.playerhand)
            {
                handValue.Add(card.value);
            }

            //checking if hand contains an ace
            if (handValue.Contains(11))
            {
                foreach (Card card in Player.playerhand)
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
            foreach (Card card in Player.playerhand)
            {
                Console.WriteLine($"{card.name} of {card.suit}");
            }
            Console.WriteLine($"Value : {handvalue}");
            if(handvalue == 21)
            {

            }
        }

        public static void GetDealerValue()
        {
            dealerhandvalue.Clear();
            foreach(Card card in Player.dealerhand)
            {
                dealerhandvalue.Add(card.value);
            }
            int deal = dealerhandvalue.Sum();
            if (deal > 21 && dealerhandvalue.Contains(11))
            {
                deal = deal - 10;
            }
            Console.WriteLine($"Dealer Hand : {deal}");
        }

        public static void GetFirstDealerCard()
        {
            Card firstcard = dealerhand[1];
            Console.WriteLine($"{firstcard.name} of {firstcard.suit}");
        }

        public static void DealerDraw()
        {
            int r1 = rng.Next(0, (Deck.cards.Count) - 1);
            Card dealerCard = Deck.cards[r1];
            Deck.cards.RemoveAt(r1);
            dealerhand.Add(dealerCard);
        }
        public static void Hit()
        {
            int r0 = rng.Next(0, (Deck.cards.Count) - 1);
            Card chosenCard = Deck.cards[r0];
            Deck.cards.RemoveAt(r0);
            Player.playerhand.Add(chosenCard);
        }


    }
}
