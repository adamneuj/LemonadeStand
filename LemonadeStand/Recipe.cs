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
            AddPitchers();
            AddLemonsToRecipe();
            AddSugarToRecipe();
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
        int AddLemonsToRecipe()
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
                return AddLemonsToRecipe();
            }
        }

        int AddSugarToRecipe()
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
                return AddSugarToRecipe();
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
        public Player RemoveItemsFromInventory(Player player)
        {
            int counter = amountOfLemons * amountOfPitchers;
            player.inventory.lemons.RemoveRange(0, counter);
            counter = amountOfSugar * amountOfPitchers;
            player.inventory.sugar.RemoveRange(0, counter);
            return player;
        }
        //TODO FINISH VALIDATION
        //void ValidatePitcher(Player player)
        //{
        //    if(amountOfPitchers >= 2 && player.inventory.lemons.Count() == 1)
        //    {
        //        Console.WriteLine("You can only make 1 pitcher of lemonade.");
        //        AddPitchers(player);
        //    }
        //}
    }
}
