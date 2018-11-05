using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public abstract class Item
    {
        public int amount;
        public string name;
        public Item()
        {
            amount = 15;
        }
        public bool CheckForValidAmount(int newAmount)
        {
            if (amount < newAmount)
            {
                Console.WriteLine("\nI'm sorry, you dont have enough " + name + " for that!");
                return false;
            }
            else
            {
                return true;
            }
        }
        public void IncrementInventory(int newAmount)
        {
            amount += newAmount;
        }
        public void DecrementInventory(int newAmount)
        {
            amount -= newAmount;
        }
    }
}
