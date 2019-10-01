using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game LemonadeStand = new Game();
            LemonadeStand.RunGame();

            //Display Rules !DONE!
            //Ask how long game will be played !DONE!
            //Start gameplay loop checking if there are days left in gamelength. !DONE!
                //Display weather forecast for day !DONE!
                //Display weather forecast for week
                //Buy inventory for lemonade stand - lemons, sugar, ice cubes and cups.
                //Remove money from player wallet for supplies.
                //Player will determine REFRESHING FACTOR how many lemons, sugar, and ice cubes are in each cup.
                //Player will determine how much each cup will cost.

            //Real weather generated for day loop
                //Temperature
                //Weather conditions
                //Calculate new forecast based on weather conditions of day.

            //Start day loop, checking if there is inventory left and if there is time left in day.
                //Pass 2 hours
                //Calculate how much traffic will pass by lemonade stand based on weather.
                //Calculate whether customer can afford to pay for lemonade.
                //If customer can afford lemonade, calculate interest.
                //If interest and refreshing factor met, customer will buy.
                //Else customer will not buy
                //Else customer will not buy
                //If day is over, ice cubes will melt.
                //Once day is over, calculate net income for day.
                //Add net income for day to player wallet.
        }
    }
}
