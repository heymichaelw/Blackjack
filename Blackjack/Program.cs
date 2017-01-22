using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Deck.MakeDeck();
            Deck.DealCard();
            Deck.DealCard();
            Player.GetHand();
            //foreach (Card card in Player.hand)
            //{
            //   Console.WriteLine($"{card.name} of {card.suit} : {card.value}");
            //}
            //Player.GetHandValue();
            //Console.WriteLine($"{Player.handvalue}");

        }
    }
}
