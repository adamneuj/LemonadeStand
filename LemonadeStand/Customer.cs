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
        public int demand;  // Demand is calculated as 1 = not interested, 2 = neutral, 3 = very interested
        public int sourThreshold;
        public int sweetThreshold;

        //member methods
        public Customer(Weather weather)
        {
            CalculateDemand(weather);
            CalculateSourThreshold();
            CalculateSweetThreshold();
        }

        int CalculateDemand(Weather weather)
        {
            Random random = new Random();
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

        int CalculateSourThreshold()
        {
            Random random = new Random();
            sourThreshold = random.Next(1, 4);
            return sourThreshold;
        }

        int CalculateSweetThreshold()
        {
            Random random = new Random();
            sweetThreshold = random.Next(1, 4);
            return sweetThreshold;
        }
    }
}
