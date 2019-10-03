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
        public int amountOfPitchers;
        public double pricePerCup;
        string recipeString;

        //constructor
        public Recipe()
        {
            Messages.ClearConsole();
            Messages.DisplayInventory();
            AddPitchers();
            AddLemons();
            AddSugar();
            AddIceCubesPerCup();
            DeterminePricePerCup();
        }

        //member methods
        int AddPitchers()
        {
            Console.WriteLine("How many pitchers of lemonade would you like to make today?");
            recipeString = Console.ReadLine();
            if (Int32.TryParse(recipeString, out amountOfPitchers))
            {
                return amountOfPitchers;
            }
            else
            {
                Messages.DisplayInvalidInput();
                return AddPitchers();
            }
        }
        int AddLemons()
        {
            Console.WriteLine("How many lemons per pitcher?");
            recipeString = Console.ReadLine();
            if (Int32.TryParse(recipeString, out amountOfLemons))
            {
                return amountOfLemons;
            }
            else
            {
                Messages.DisplayInvalidInput();
                return AddLemons();
            }
        }

        int AddSugar()
        {
            Console.WriteLine("How many cups of sugar per pitcher?");
            recipeString = Console.ReadLine();
            if (Int32.TryParse(recipeString, out amountOfSugar))
            {
                return amountOfSugar;
            }
            else
            {
                Messages.DisplayInvalidInput();
                return AddSugar();
            }
        }
        int AddIceCubesPerCup()
        {
            Console.WriteLine("How many ice cubes do you want per cup?");
            recipeString = Console.ReadLine();
            if (Int32.TryParse(recipeString, out amountOfIceCubes))
            {
                return amountOfIceCubes;
            }
            else
            {
                Messages.DisplayInvalidInput();
                return AddIceCubesPerCup();
            }
        }
        double DeterminePricePerCup()
        {
            Console.WriteLine("What will the price be per cup?");
            recipeString = Console.ReadLine();
            if (Double.TryParse(recipeString, out pricePerCup))
            {
                return pricePerCup = Math.Round(pricePerCup, 2);
            }
            else
            {
                Messages.DisplayInvalidInput();
                return DeterminePricePerCup();
            }
        }
        //void CheckInventory(Day day, Weather weather, Player player, Store store)
        //{
        //    if (player.inventory.lemons.Count < amountOfLemons)
        //    {
        //        Messages.DisplayNeedToGoToStore();
        //        amountOfLemons = 0;
        //        MainMenu.CallMenu(day, weather, player, store);
        //    }
        //    else if (player.inventory.sugar.Count < amountOfSugar)
        //    {
        //        Messages.DisplayNeedToGoToStore();
        //        amountOfLemons = 0;
        //        amountOfSugar = 0;
        //        MainMenu.CallMenu(day, weather, player, store);
        //    }
        //    else if (player.inventory.iceCubes.Count < amountOfIceCubes)
        //    {
        //        Messages.DisplayNeedToGoToStore();
        //        amountOfLemons = 0;
        //        amountOfSugar = 0;
        //        amountOfIceCubes = 0;
        //        MainMenu.CallMenu(day, weather, player, store);
        //    }
        //    else if (player.inventory.cups.Count == 0)
        //    {
        //        amountOfLemons = 0;
        //        amountOfSugar = 0;
        //        amountOfIceCubes = 0;
        //        Messages.DisplayNeedToGoToStore();
        //        MainMenu.CallMenu(day, weather, player, store);
        //    }
        //}
    }
}
