using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Program
    {
        public static bool isActive;
        public static bool isPlaying;

        static void Main(string[] args)
        {
            Deck.MakeDeck();
            Deck.DealCard();
            Deck.DealCard();
            Player.CheckTwoCards();
            Console.WriteLine("Welcome to the game of Blackjack!");
            Console.WriteLine("The dealer's first card is:");
            Player.GetFirstDealerCard();
            Console.WriteLine("Your hand is:");
            while (isPlaying ==true)
            {
                Game();
            }
        }

        public static void Game()
        {
            Player.GetHand();
            Console.WriteLine("Would you like to Hit or Stand?  [H / S]");
            var choice = Char.ToUpper(Char.Parse(Console.ReadLine()));
            if (choice == 'H')
            {
                Player.Hit();
                Player.DealerDraw();
            }
            else
            {
                Player.DealerDraw();
                isActive = false;
            }
            Player.CheckState();

            

        }
    }
}
