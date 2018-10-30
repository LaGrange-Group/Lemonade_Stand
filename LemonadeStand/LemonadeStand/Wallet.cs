using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {
        private double money;
        public double Money
        {
            get
            {
                return money;
            }
        }
        public Wallet()
        {
            money = 20;
        }
        public void IncramentMoney(double cost)
        {
            money += cost;
        }
        public void DecrementMoney(double amount)
        {
            money -= amount;
        }
        public bool CheckIfEnoughMoney(double amount)
        {
            if (money < amount)
            {
                Console.WriteLine("\nI'm sorry, you dont have enough money for this!");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
