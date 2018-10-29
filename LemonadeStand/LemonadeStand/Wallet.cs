using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {
        private int money;
        public Wallet()
        {
            money = 20;
        }
        private void IncramentMoney(int cost)
        {
            money += cost;
        }
    }
}
