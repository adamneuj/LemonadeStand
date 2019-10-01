using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        //member methods
        public List<Lemon> lemons;
        public List<Sugar> cupsOfSugar;
        public List<IceCube> iceCubes;
        public List<Cup> cups;

        //constructor
        public Inventory()
        {
            lemons = new List<Lemon>();
            cupsOfSugar = new List<Sugar>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
        }
        //member variables
    }
}
