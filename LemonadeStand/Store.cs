﻿using System;
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
        Sugar sugar;

        //constructor
        public Store()
        {
            multiplier = 0;
            storeInput = null;
            lemon = new Lemon();
            sugar = new Sugar();
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
            else if(storeInput == "sugar")
            {
                BuySugar(player);
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

        public Player BuySugar(Player player)
        {
            Messages.DisplaySugarPrice(sugar);
            Console.WriteLine("How many cups of sugar would you like to buy?");
            storeInput = Console.ReadLine();
            if (Int32.TryParse(storeInput, out multiplier))
            {
                if (sugar.price * multiplier < player.wallet.money)
                {
                    while (multiplier != 0)
                    {
                        player.inventory.sugar.Add(new Sugar());
                        PurchaseSugar(player);
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
            player.wallet.money = Math.Round(player.wallet.money, 2);
            return player;
        }

        public Player PurchaseSugar(Player player)
        {
            player.wallet.money -= sugar.price;
            player.wallet.money = Math.Round(player.wallet.money, 2);
            return player;
        }

    }
}
