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

        //constructor
        public Player()
        {

        }

        //member methods
        public void NameYourPlayer()
        {
            Messages.AskName();
            name = Console.ReadLine();
        }
    }
}
