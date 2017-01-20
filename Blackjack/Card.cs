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
        List<int> CardValues = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        List<string> CardNames = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        public Card()
        {

        }

        public Card(int _value, string _name)
        {
            value = _value;
            name = _name;
        }
        

        public int GetValue()
        {
            return value;
        }

        public int setCardValue()
        {
            return 0;
        }
    }
}
