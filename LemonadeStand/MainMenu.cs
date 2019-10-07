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
            Messages.DisplayMainMenu(day, weather, player);
            menuInput = Console.ReadLine();
            if (menuInput == "1")
            {
                store.BuyFromStore(player);
                CallMenu(day, weather, player, store);
            }
            else if (menuInput == "2")
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
                player.lemonadeStand.pricePerCup = recipe.pricePerCup;
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
