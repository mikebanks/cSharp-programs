using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Golf
{
    class Dice
    {
        private Random randomNumbers = new Random();

        public int Roll()
        {
            return randomNumbers.Next(1, 7);
        }
    }
}
