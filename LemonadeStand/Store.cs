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
        Lemon lemonDisplay;

        //constructor
        public Store()
        {
            multiplier = 0;
            storeInput = null;
            lemonDisplay = new Lemon();
        }
        //member methods
        public Player EnterStore(Player player)
        {
            Console.WriteLine("Would you like to buy lemons, sugar, ice cubes, or cups?");
            storeInput = Console.ReadLine();
            storeInput = storeInput.ToLower();
            if (storeInput == "lemons")
            {
                DisplayLemonPrice(lemonDisplay);
                Console.WriteLine("How many lemons would you like to buy?");
                storeInput = Console.ReadLine();
                if (Int32.TryParse(storeInput, out multiplier))
                {
                    while (multiplier != 0)
                    {
                        player.inventory.lemons.Add(new Lemon());
                        multiplier--;
                    }
                    storeInput = null;
                    return player;
                }
                else
                {
                    Messages.DisplayInvalidInput();
                    storeInput = null;
                    return EnterStore(player);
                }
            }
            else
            {
                return player;
            }
        }
        private void DisplayLemonPrice(Lemon lemon)
        {
            Console.WriteLine("The price per lemon is $" + lemon.Price);
        }

    }
}
