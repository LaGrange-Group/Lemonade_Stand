using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        Weather weather;
        Customer customer;

        public Day()
        {
            weather = new Weather();
            customer = new Customer();
        }
    }
}
