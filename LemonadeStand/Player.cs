using System;
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

        //constructor
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
        }

        //member methods
        public void NameYourPlayer()
        {
            Messages.AskName();
            name = Console.ReadLine();
            Console.Clear();
        }
    }
}
