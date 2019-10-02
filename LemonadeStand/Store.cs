using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        //member variables
        int multiplier;
        string storeInput;
        Game playerOne;

        //constructor
        public Store()
        {
            
        }
        //member methods
        public void DisplayStore()
        {
            Console.WriteLine("Would you like to buy lemons, sugar, ice cubes, or cups?");
            storeInput = Console.ReadLine();
            storeInput = storeInput.ToLower();
            if (storeInput == "lemons")
            {
                Console.WriteLine("How many lemons would you like to buy?");
                storeInput = Console.ReadLine();
                if (Int32.TryParse(storeInput, out multiplier))
                {
                    Console.WriteLine("Multiplier value: " + multiplier);
                    while (multiplier != 0)
                    {
                        Lemon lemon = new Lemon();
                    }

                }
                else
                {
                    Messages.DisplayInvalidInput();
                    DisplayStore();
                }
            }
        }

    }
}
