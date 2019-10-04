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

        public void CalculateDemand(Weather weather)
        {
            Random random = new Random(); // Demand is calculated as 1 = not interested, 2 = neutral, 3 = very interested
            if (weather.temperature >= 90)
            {
                demand = 3;
            }
            else if(weather.temperature < 90 && weather.temperature >= 80)
            {
                demand = random.Next(2, 4);
            }
            else if(weather.temperature < 80 && weather.temperature >= 65)
            {
                demand = random.Next(1, 4);
            }
            else
            {
                demand = 1;
            }
        }


    }
}
