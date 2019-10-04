using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class RandomGenerator
    {
        public static double GetRandomDouble(double minimum, double maximum) //Single Responsibility Principle
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

        public static int GetRandomInt(int minimum, int maximum) //Single Responsibility Principle
        {
            Random random = new Random();
            return random.Next(minimum, maximum + 1);
        }
    }
}
