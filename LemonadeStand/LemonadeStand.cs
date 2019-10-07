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
        public double profit;
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
        public Player ServeCustomers(Player player)
        {
            for(int i = 0; i < passerbys.Count(); i++)
            {
                if (pitchers.Count() == 0)
                {
                    player.wallet.money += profit;
                    return player;
                }
                else if (passerbys[i].demand >= 2 && passerbys[i].sourThreshold >= pitchers[0].sourFactor && passerbys[i].sweetThreshold >= pitchers[0].sweetFactor && passerbys[i].money >= pricePerCup)
                {
                    passerbys[i].money -= pricePerCup;
                    profit += pricePerCup;
                    pitchers[0].cupsPerPitcher--;
                    if(pitchers[0].cupsPerPitcher == 0)
                    {
                        pitchers.RemoveAt(0);
                        continue;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }
            }
            pitchers.RemoveRange(0, pitchers.Count());
            player.wallet.money += profit;
            Console.WriteLine("Profits today: " + profit); // remove
            Console.ReadLine();
            return player;
        }
    }
}
