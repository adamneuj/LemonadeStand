using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //member variables
        int i;
        string[] daysOfTheWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        public string day;

        //constructor
        public Day()
        {
            Weather weather = new Weather();
            i = 0;
            day = daysOfTheWeek[i];
        }

        //member methods
        public string DetermineDay()
        {
            if (i > 6)
            {
                i = 0;
                day = daysOfTheWeek[i];
                return day;
            }
            else
            {
                i++;
                day = daysOfTheWeek[i];
                return day;
            }
        }
    }
}
