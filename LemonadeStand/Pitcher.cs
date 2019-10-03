using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Pitcher
    {
        public int cupsPerPitcher;
        public int lemons;
        public int sugar;

        public Pitcher(Recipe recipe)
        {
            cupsPerPitcher = 4;
            lemons = recipe.amountOfLemons;
            sugar = recipe.amountOfSugar;
        }
    }
}
