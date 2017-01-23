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
        public static int dealervalue = dealerhandvalue.Sum();
        public static int handvalue = handValue.Sum();
        public static Random rng = new Random();
        public static bool isPlaying;
        public static bool isActive;

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

            handvalue = handValue.Sum();
            return handvalue;

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
        }

        public static void CheckTwoCards()
        {
            if (handvalue == 21)
            {
                Console.WriteLine("Congratulations!  You got Blackjack!");
            }
        }


        public static int GetDealerValue()
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
            return deal;
        }

        public static void GetDealerHand()
        {
            GetDealerValue();
            foreach (Card card in Player.dealerhand)
            {
                Console.WriteLine($"{card.name} of {card.suit}");
            }
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
        
        public static void CheckState()
        {
            if(handvalue == 21)
            {
                Console.WriteLine("Blackjack!  You win!");
                isPlaying = false;
            }
            else if (handvalue > 21)
            {
                Console.WriteLine("Bust!  You lose!");
                isPlaying = false;
            }
            else if (dealervalue == 21)
            {
                Console.WriteLine("The dealer got Blackjack!  You lose!");
                isPlaying = false;
            }
            else if (dealervalue > 21)
            {
                Console.WriteLine("The dealer busted!  You win!");
                isPlaying = false;
            }
            else if (isActive = false && handvalue > dealervalue)
            {
                Console.WriteLine("You scored higher than the dealer!  You win!");
            }
            else
            {
                Console.WriteLine("The dealer scored higher.  You lose!");
            }
        }

    }
}
