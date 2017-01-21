using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck.MakeDeck();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            Deck.DealCard();
            foreach (Card card in Deck.cards)
            {
                Console.WriteLine($"{card.name} of {card.suit} : {card.value}");
            }


        }
    }
}
