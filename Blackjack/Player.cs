using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Player
    {
        public int handSize = 0;
        private static int handValue = 0;
        private int buffer = (21 - handValue);
        private int bust = 21;

        public Player()
        {

        }

        public Player(int _handsize, int _handvalue)
        {
            handSize = _handsize;
            handValue = _handvalue;
        }

        public int GethandValue()
        {
            return handValue;
        }

        public int Getbuffer()
        {
            return buffer;
        }


    }
}
