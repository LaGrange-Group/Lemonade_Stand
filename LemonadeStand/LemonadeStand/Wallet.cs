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
        public void IncramentMoney(int cost)
        {
            money += cost;
        }
        public void DecrementMoney(int amount)
        {
            money -= amount;
        }
        public bool CheckIfEnoughMoney(int amount)
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
