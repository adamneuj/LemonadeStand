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
                Messages.ShowInventory(player);
                Messages.PressEnterToContinue();
                CallMenu(day, weather, player, store);
            }
            else if (menuInput == "2")
            {
                store.EnterStore(player);
                CallMenu(day, weather, player, store);
            }
            else if (menuInput == "3")
            {
                Messages.ShowInventory(player);
                Console.WriteLine();
                Recipe recipe = new Recipe();
                recipe.RemoveItemsFromInventory(player);
                while (recipe.amountOfPitchers != 0)
                {
                    player.lemonadeStand.pitchers.Add(new Pitcher(recipe));
                    recipe.amountOfPitchers--;
                }
                Console.WriteLine("Pitchers for lemonade stand: " + player.lemonadeStand.pitchers.Count());
                Messages.PressEnterToContinue();
                CallMenu(day, weather, player, store);
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
