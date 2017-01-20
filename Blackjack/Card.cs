using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Card
    {
        private int value;
        public string name;
        public string suit;
        //List<int> CardValues = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        
        

        public Card()
        {

        }

        public Card(string _name, string _suit, int _value)
        {
     
            name = _name;
            suit = _suit;
            value = _value;
        }
        

        public void GetValue()
        {
            
        }

        public int setCardValue()
        {
            return 0;
        }
    }
}
