﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        //member variables
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public LemonadeStand lemonadeStand;

        //constructor
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            lemonadeStand = new LemonadeStand();
        }

        //member methods
        public void NameYourPlayer()
        {
            Messages.AskName();
            name = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(name))
            {
                Messages.DisplayInvalidInput();
                Console.Clear();
                NameYourPlayer();
            }
            else
            {
                Console.Clear();
            }

        }
    }
}
