using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Messages
    {

        public static void DisplayRules()
        {
            Congratulate();
            Console.WriteLine("You have just opened your first business, a lemonade stand!");
            Console.WriteLine("You might be thinking that this is a terrible first business.");
            Console.WriteLine("There are low profit margins and nobody buys lemonade anymore.");
            Console.WriteLine("Let me assure you, that this is incorrect.");
            Console.WriteLine("If you play your cards right, then you can make an amazing net profit off of this.");
            Console.WriteLine("Now you might be thinking, 'How do you even make a good profit off of this?'");
            Console.WriteLine("Well, it's simple supply and demand.");
            Console.WriteLine("What your potential customer will buy is determined by a variety of factors.");
            Console.WriteLine("How refreshing your lemonade will be is one of the greatest factors.");
            Console.WriteLine("Nobody will want to buy your product unless it's refreshing.");
            Console.WriteLine("Your recipe per cup determines how refreshing it will be.");
            Console.WriteLine("You will need to determine how many lemons, and cups of sugar will be in each pitcher.");
            Console.WriteLine("You will then need to determine how many ice cubes are in each cup.");
            Console.WriteLine("Remember, what the weather is like and how many ice cubes will determine how refreshing a cup of lemonade is as well.");
            Console.WriteLine("Also, another determining factor of your business is the time of day and the day of the week.");
            Console.WriteLine("You will have more traffic when people are not at work.");
            Console.WriteLine("Now that you have the basic gist of it, go get that paper!");
            Console.WriteLine("Good luck!");
            PressEnterToContinue();
        }
        public static void Congratulate()
        {
            Console.WriteLine("Congratulations, Entrepreneur!");
        }
        public static void PressEnterToContinue()

        {
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
        public static void AskName()
        {
            Console.WriteLine("It seems I forgot to ask to whom I am speaking.");
            Console.WriteLine("What is your name, Entrepreneur?");
        }

        public static void DisplayWeather(Weather weather)
        {
            Console.WriteLine("Temperature: " + weather.temperature);
            Console.WriteLine("Condition: " + weather.condition);
        }

        public static void DisplayTodaysWeather(Weather weather)
        {
            Console.WriteLine("Today's weather will be...");
            DisplayWeather(weather);
        }

        public static void DisplayDay(Day day, Weather weather)
        {
            Console.WriteLine("Today is " + day.day);
            DisplayTodaysWeather(weather);
        }
        public static void DisplayInvalidInput()
        {
            Console.WriteLine("Invalid input.");
        }
        public static void DisplayLemonPrice(Lemon lemon)
        {
            Console.WriteLine("The price per lemon is $" + lemon.price);
        }

        public static void DisplaySugarPrice(Sugar sugar)
        {
            Console.WriteLine("The price per cup of sugar is $ " + sugar.price);
        }
        public static void DisplayIcePrice(IceCube iceCube)
        {
            Console.WriteLine("The price per ice cube is $ " + iceCube.price);
        }

        public static void DisplayCupPrice(Cup cup)
        {
            Console.WriteLine("The price per ice cube is $ " + cup.price);
        }
        public static void ShowInventory(Player player)
        {
            Console.Clear();
            Console.WriteLine("Inventory");
            Console.WriteLine("Lemons: " + player.inventory.lemons.Count());
            Console.WriteLine("Cups of Sugar: " + player.inventory.sugar.Count());
            Console.WriteLine("Ice Cubes: " + player.inventory.iceCubes.Count());
            Console.WriteLine("Cups: " + player.inventory.cups.Count());
            Console.WriteLine("Money: $" + player.wallet.money);
            PressEnterToContinue();
        }
        public static void DisplayNeedToGoToStore()
        {
            Console.WriteLine("You will need to go to the store for more supplies.");
            PressEnterToContinue();
        }

        public static void DisplayMainMenu(Weather weather)
        {
            DisplayWeather(weather);
            Console.WriteLine();
            Console.WriteLine("What would you like to do before you open for the day?");
            Console.WriteLine("Press 1 to view inventory.");
            Console.WriteLine("Press 2 to go to the store.");
            Console.WriteLine("Press 3 to set your recipe for the day.");
            Console.WriteLine("Press 4 to open for the day.");

        }

    }
}
