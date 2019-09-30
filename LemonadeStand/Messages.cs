﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Messages
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

    }
}