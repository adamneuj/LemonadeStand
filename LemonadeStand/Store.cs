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
        Lemon lemon;

        //constructor
        public Store()
        {
            multiplier = 0;
            storeInput = null;
            lemon = new Lemon();
        }
        //member methods
        public Player BuyFromStore(Player player)
        {
            Console.WriteLine("Would you like to buy lemons, sugar, ice cubes, or cups?");
            storeInput = Console.ReadLine();
            storeInput = storeInput.ToLower();
            if (storeInput == "lemons")
            {
                BuyLemons(player);
                return player;
            }
            else
            {
                return player;
            }
        }

        public Player BuyLemons(Player player)
        {
            Messages.DisplayLemonPrice(lemon);
            Console.WriteLine("How many lemons would you like to buy?");
            storeInput = Console.ReadLine();
            if (Int32.TryParse(storeInput, out multiplier))
            {
                if (lemon.price * multiplier < player.wallet.money)
                {
                    while (multiplier != 0)
                    {
                        player.inventory.lemons.Add(new Lemon());
                        PurchaseLemon(player);
                        multiplier--;
                    }
                    storeInput = null;
                    return player;
                }
                else
                {
                    Console.WriteLine("Not enough money.");
                    return BuyFromStore(player);
                }
            }
            else
            {
                Messages.DisplayInvalidInput();
                storeInput = null;
                Console.Clear();
                return BuyFromStore(player);
            }
        }

        public Player PurchaseLemon(Player player)
        {
            player.wallet.money -= lemon.price;
            return player;
        }

    }
}
