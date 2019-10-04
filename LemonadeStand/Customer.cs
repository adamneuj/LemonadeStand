using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //member variables
        public double wallet;
        public int demand;
        public int sourThreshold;
        public int sweetThreshold;

        //member methods
        public Customer(Weather weather, Pitcher pitcher)
        {
            CalculateDemand(weather);
        }

        public int CalculateDemand(Weather weather)
        {
            Random random = new Random(); // Demand is calculated as 1 = not interested, 2 = neutral, 3 = very interested
            if (weather.temperature >= 90)
            {
                return demand = 3;
            }
            else if(weather.temperature < 90 && weather.temperature >= 80)
            {
                return demand = random.Next(2, 4);
            }
            else if(weather.temperature < 80 && weather.temperature >= 60)
            {
                return demand = random.Next(1, 4);
            }
            else
            {
                return demand = 1;
            }
        }


    }
}
