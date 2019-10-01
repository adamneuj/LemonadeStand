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
        public static string day;

        //constructor
        public Day()
        {
            i = 0;
            day = daysOfTheWeek[i];
        }

        //member methods
        public string CycleDay()
        {
            if (i == 6)
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
