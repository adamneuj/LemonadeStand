using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Pitcher
    {
        //member variables
        public int cupsPerPitcher;
        public int lemons;
        public int sugar;
        public int sourFactor; //1 = not sour enough, 2 = just right, 3 = too sour;
        public int sweetFactor; //1 = not sweet enough, 2 = just right, 3 = too sweet;

        //constructor
        public Pitcher(Recipe recipe)
        {
            cupsPerPitcher = 4;
            lemons = recipe.amountOfLemons;
            CalculateSourFactor();
            sugar = recipe.amountOfSugar;
            CalculateSweetFactor();
        }

        //member methods
        public int CalculateSourFactor()
        {
            if(lemons > 5)
            {
                return sourFactor = 3;
            }
            else if(lemons <= 5 && lemons >= 3)
            {
                return sourFactor = 2;
            }
            else
            {
                return sourFactor = 1;
            }
        }
        public int CalculateSweetFactor()
        {
            if(sugar > 2)
            {
                return sweetFactor = 3;
            }
            else if(sugar == 2)
            {
                return sweetFactor = 2;
            }
            else
            {
                return sweetFactor = 1;
            }
        }
    }
}
