using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Dice
    {
        private Random _randomizer = new();
        public int Dots { get; private set; }

        public Dice() {
            Dots = 6;
        }


        private readonly Random _random = new Random();
        public int Roll()
        {
            return _randomizer.Next(1, 7);
        }
    }
}
