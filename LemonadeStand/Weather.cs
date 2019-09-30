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
        public int temprature;
        public List<string> weatherConditions;
        public string predictedForecast;

        //constructor
        public Weather()
        {
            weatherConditions = new List<string>() { "Sunny", "Partly Cloudy", "Cloudy", "Rain" };
        }

        //member methods
    }
}
