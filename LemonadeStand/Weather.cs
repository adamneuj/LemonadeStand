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
        public string predictedForecast;

        //constructor
        public Weather()
        {
            weatherConditions = new List<string>() { "Sunny", "Partly Cloudy", "Cloudy", "Rain" };
            RandomTemp();
        }

        //member methods
        public void RandomTemp()
        {
            Random random = new Random();
            temperature = random.Next(60, 101);
        }
    }
}
