using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class MainMenu
    {
        public static string menuInput;

        public static void CallMenu(Day day, Weather weather, Player player, Store store)
        {
            Messages.DisplayMainMenu(day, weather);
            menuInput = Console.ReadLine();
            if (menuInput == "1")
            {
                menuInput = null;
                Messages.ShowInventory(player);
                CallMenu(day, weather, player, store);
            }
            else if (menuInput == "2")
            {
                menuInput = null;
                store.EnterStore(player);
                CallMenu(day, weather, player, store);
            }
            else if (menuInput == "3")
            {
                //TO DO - SET RECIPE
            }
            else if (menuInput == "4")
            {
                //TO DO - START BUSINESS DAY
            }
            else
            {
                Messages.DisplayInvalidInput();
                Console.Clear();
                CallMenu(day, weather, player, store);
            }
        }
    }
}
