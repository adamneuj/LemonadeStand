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
        public Player CreateRecipe(Player player)
        {
            Messages.ClearConsole();
            AddLemonsToPitcher(player);
            AddSugarToPitcher(player);
            DetermineAmountOfIceCubesPerCup(player);
            DeterminePricePerCup();
            return player;
        }

        Player AddLemonsToPitcher(Player player)
        {
            Console.WriteLine("How many lemons per pitcher?");
            recipeString = Console.ReadLine();
            if (Int32.TryParse(recipeString, out counter))
            {
                amountOfLemons = counter;
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
                return AddLemonsToPitcher(player);
            }
        }

        Player AddSugarToPitcher(Player player)
        {
            Console.WriteLine("How many cups of sugar per pitcher?");
            recipeString = Console.ReadLine();
            if (Int32.TryParse(recipeString, out counter))
            {
                amountOfSugar = counter;
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
                return AddSugarToPitcher(player);
            }
        }

        Player DetermineAmountOfIceCubesPerCup(Player player)
        {
            Console.WriteLine("How many ice cubes do you want per cup?");
            recipeString = Console.ReadLine();
            if (Int32.TryParse(recipeString, out counter))
            {
                amountOfIceCubes = counter;
                return player;
            }
            else
            {
                Messages.DisplayInvalidInput();
                return DetermineAmountOfIceCubesPerCup(player);
            }
        }

        void DeterminePricePerCup()
        {
            Console.WriteLine("What will the price be per cup?");
            recipeString = Console.ReadLine();
            if (Double.TryParse(recipeString, out pricePerCup))
            {
                pricePerCup = Math.Round(pricePerCup, 2);
            }
            else
            {
                Messages.DisplayInvalidInput();
                DeterminePricePerCup();
            }
        }

    }
}
