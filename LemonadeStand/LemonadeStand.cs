using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class LemonadeStand
    {
        //member variables
        public double pricePerCup;
        public List<Pitcher> pitchers;
        public int footTraffic;
        public List<Customer> passerbys;
        //constructor

        public LemonadeStand()
        {
            pitchers = new List<Pitcher>();
            passerbys = new List<Customer>();
        }

        //member methods
        public int GenerateFootTraffic(Weather weather)
        {
            if(weather.condition == "Sunny")
            {
                return footTraffic = RandomGenerator.GetRandomInt(80, 101);
            }
            else if(weather.condition == "Partly Cloudy")
            {
                return footTraffic = RandomGenerator.GetRandomInt(60, 101);
            }
            else if(weather.condition == "Cloudy")
            {
                return footTraffic = RandomGenerator.GetRandomInt(40, 71);
            }
            else
            {
                return footTraffic = RandomGenerator.GetRandomInt(5, 31);
            }
        }

        public List<Customer> GeneratePasserbys(Weather weather)
        {
            while(footTraffic != 0)
            {
                passerbys.Add(new Customer(weather));
                footTraffic--;
            }
            return passerbys;
        }
    }
}
