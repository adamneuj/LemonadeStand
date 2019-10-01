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
        public int wallet;

        //constructor
        public Player()
        {
            Inventory inventory = new Inventory();
        }

        //member methods
        public void NameYourPlayer()
        {
            Messages.AskName();
            name = Console.ReadLine();
        }
    }
}
