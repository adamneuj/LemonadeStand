using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        //member variables
        public int amountOfLemons;
        public int amountOfSugar;
        public int amountOfIceCubes;
        public double pricePerCup;
        string recipeString;
        int counter;

        //constructor
        public Recipe()
        {

        }

        //member methods
        public Player CreateRecipe(Day day, Weather weather, Player player, Store store)
        {
            Messages.ClearConsole();
            AddLemonsToPitcher(day, weather, player, store);
            AddSugarToPitcher(day, weather, player, store);
            DetermineAmountOfIceCubesPerCup(day, weather, player, store);
            DeterminePricePerCup(day, weather, player, store);
            return player;
        }

        Player AddLemonsToPitcher(Day day, Weather weather, Player player, Store store)
        {
            Console.WriteLine("How many lemons per pitcher?");
            recipeString = Console.ReadLine();
            if (Int32.TryParse(recipeString, out counter))
            {
                amountOfLemons = counter;
                CheckInventory(day, weather, player, store);
                while (counter != 0)
                {
                    player.inventory.lemons.RemoveAt(0);
                    counter--;
                }
                return player;
            }
            else
            {
                Messages.DisplayInvalidInput();
                return AddLemonsToPitcher(day, weather, player, store);
            }
        }

        Player AddSugarToPitcher(Day day, Weather weather, Player player, Store store)
        {
            Console.WriteLine("How many cups of sugar per pitcher?");
            recipeString = Console.ReadLine();
            if (Int32.TryParse(recipeString, out counter))
            {
                amountOfSugar = counter;
                CheckInventory(day, weather, player, store);
                while (counter != 0)
                {
                    player.inventory.sugar.RemoveAt(0);
                    counter--;
                }
                return player;
            }
            else
            {
                Messages.DisplayInvalidInput();
                return AddSugarToPitcher(day, weather, player, store);
            }
        }

        Player DetermineAmountOfIceCubesPerCup(Day day, Weather weather, Player player, Store store)
        {
            Console.WriteLine("How many ice cubes do you want per cup?");
            recipeString = Console.ReadLine();
            if (Int32.TryParse(recipeString, out counter))
            {
                amountOfIceCubes = counter;
                CheckInventory(day, weather, player, store);
                return player;
            }
            else
            {
                Messages.DisplayInvalidInput();
                return DetermineAmountOfIceCubesPerCup(day, weather, player, store);
            }
        }

        void DeterminePricePerCup(Day day, Weather weather, Player player, Store store)
        {
            Console.WriteLine("What will the price be per cup?");
            recipeString = Console.ReadLine();
            if (Double.TryParse(recipeString, out pricePerCup))
            {
                CheckInventory(day, weather, player, store);
                pricePerCup = Math.Round(pricePerCup, 2);
            }
            else
            {
                Messages.DisplayInvalidInput();
                DeterminePricePerCup(day, weather, player, store);
            }
        }
        void CheckInventory(Day day, Weather weather, Player player, Store store)
        {
            if (player.inventory.lemons.Count < amountOfLemons)
            {
                Messages.DisplayNeedToGoToStore();
                amountOfLemons = 0;
                MainMenu.CallMenu(day, weather, player, store);
            }
            else if (player.inventory.sugar.Count < amountOfSugar)
            {
                Messages.DisplayNeedToGoToStore();
                amountOfLemons = 0;
                amountOfSugar = 0;
                MainMenu.CallMenu(day, weather, player, store);
            }
            else if (player.inventory.iceCubes.Count < amountOfIceCubes)
            {
                Messages.DisplayNeedToGoToStore();
                amountOfLemons = 0;
                amountOfSugar = 0;
                amountOfIceCubes = 0;
                MainMenu.CallMenu(day, weather, player, store);
            }
            else if (player.inventory.cups.Count == 0)
            {
                amountOfLemons = 0;
                amountOfSugar = 0;
                amountOfIceCubes = 0;
                Messages.DisplayNeedToGoToStore();
                MainMenu.CallMenu(day, weather, player, store);
            }
        }
    }
}
