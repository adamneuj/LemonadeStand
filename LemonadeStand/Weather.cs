using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //member variables
        public string condition;
        public int temperature;
        public List<string> weatherConditions;

        //constructor
        public Weather()
        {
            weatherConditions = new List<string>() { "Sunny", "Partly Cloudy", "Cloudy", "Rain" };
        }

        //member methods
        int RandomTemp()
        {
            Random randomTemp = new Random();
            if (condition == "Sunny")
            {
                return temperature = randomTemp.Next(80, 101);
            }
            else if(condition == "Partly Cloudy")
            {
                return temperature = randomTemp.Next(70, 91);
            }
            else if(condition == "Cloudy")
            {
                return temperature = randomTemp.Next(60, 76);
            }
            else if(condition == "Rain")
            {
                return temperature = randomTemp.Next(50, 66);
            }
            else
            {
                temperature = 100;
                return temperature;
            }
        }
        string RandomCondition()
        {
            Random randomCondition = new Random();
            int i = randomCondition.Next(0, 4);
            return condition = weatherConditions[i];
        }
        public void GenerateWeather()
        {
            RandomCondition();
            RandomTemp();
        }
    }
}
