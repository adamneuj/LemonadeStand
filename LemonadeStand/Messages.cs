using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Messages
    {
        public static void ClearConsole()
        {
            Console.Clear();
        }

        public static void DisplayRules()
        {
            Congratulate();
            Console.WriteLine("You have just opened your first business, a lemonade stand!\n" +
                "You might be thinking that this is a terrible first business\n" +
                "There are low profit margins and nobody buys lemonade anymore.\n" +
                "Let me assure you, that this is incorrect.\n" +
                "If you play your cards right, then you can make an amazing net profit off of this.\n" +
                "Now you might be thinking, 'How do you even make a good profit off of this?'\n" +
                "Well, it's simple supply and demand.\n" +
                "What your potential customer will buy is determined by a variety of factors.\n" +
                "How refreshing your lemonade will be one of the greatest factors.\n" +
                "Nobody will want to buy your product unless it's refreshing.\n" +
                "Your recipe per pitcher determines how refreshing it will be.\n" +
                "You will need to determine how many lemons, and cups of sugar will be in each pitcher.\n" +
                "You will then need to determine how many ice cubes are in each cup.\n" +
                "Now that you have the basic gist of it, go get that money!\n" +
                "Good luck!");
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
            PressEnterToContinue();
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
            DisplayLemonadeStandName(player);
            Console.WriteLine("Lemons: " + player.inventory.lemons.Count());
            Console.WriteLine("Cups of Sugar: " + player.inventory.sugar.Count());
            Console.WriteLine("Ice Cubes: " + player.inventory.iceCubes.Count());
            Console.WriteLine("Cups: " + player.inventory.cups.Count());
            Console.WriteLine("Money: $" + player.wallet.money);
            Console.WriteLine();
        }
        public static void DisplayNeedToGoToStore()
        {
            Console.WriteLine("You will need to go to the store for more supplies.");
            PressEnterToContinue();
        }

        public static void DisplayMainMenu(Day day, Weather weather, Player player)
        {
            ShowInventory(player);
            DisplayDay(day, weather);
            Console.WriteLine();
            Console.WriteLine("What would you like to do before you open for the day?");
            Console.WriteLine("Press 1 to go to the store.");
            Console.WriteLine("Press 2 to set up and open for the day.");
        }

        public static void DisplayStoreGreeting(Player player)
        {
            ShowInventory(player);
            Console.WriteLine("Welcome to the store!");
        }
        public static void DisplayItemsToBuy()
        {
            Console.WriteLine("Press 1 to buy lemons.");
            Console.WriteLine("Press 2 to buy sugar.");
            Console.WriteLine("Press 3 to buy ice cubes.");
            Console.WriteLine("Press 4 to buy cups.");
            Console.WriteLine("Press 5 to exit.");
        }
        public static void DisplayLemonadeStandName(Player player)
        {
            Console.WriteLine(player.name + "'s World Famous Lemonade");
        }

    }
}
