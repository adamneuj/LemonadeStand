﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Sugar : Item
    {
        public Sugar()
        {
            name = "sugar";
            price = .20;
        }
        public double Price
        {
            get
            {
                return price;
            }
        }
    }
}
