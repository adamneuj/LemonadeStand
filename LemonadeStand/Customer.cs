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
        public double money;
        public int demand;  // Demand is calculated as 1 = not interested, 2 = neutral, 3 = very interested
        public int sourThreshold;
        public int sweetThreshold;

        //member methods
        public Customer(Weather weather)
        {
            CalculateDemand(weather);
            CalculateSourThreshold();
            CalculateSweetThreshold();
            GenerateMoney();
        }

        int CalculateDemand(Weather weather)
        {
            if (weather.temperature >= 90)
            {
                return demand = 3;
            }
            else if(weather.temperature < 90 && weather.temperature >= 80)
            {
                return demand = RandomGenerator.GetRandomInt(2, 4);
            }
            else if(weather.temperature < 80 && weather.temperature >= 60)
            {
                return demand = RandomGenerator.GetRandomInt(1, 4);
            }
            else
            {
                return demand = 1;
            }
        }

        int CalculateSourThreshold()
        {
            sourThreshold = RandomGenerator.GetRandomInt(1, 4);
            return sourThreshold;
        }

        int CalculateSweetThreshold()
        {
            sweetThreshold = RandomGenerator.GetRandomInt(1, 4);
            return sweetThreshold;
        }

        double GenerateMoney()
        {
            money = RandomGenerator.GetRandomDouble(0.1, 1.21);
            money = Math.Round(money, 2);
            return money;
        }
    }
}
