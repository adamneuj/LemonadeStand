using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {
        double money;

        public Wallet()
        {
            money = 10;
        }

        public double Money
        {
            get
            {
                return money;
            }
        }
    }
}
