using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public abstract class Inventory
    {
        protected int amount;
        public Inventory()
        {
            amount = 0;
        }
        public void IncramentInventory(int newAmount)
        {
            amount += newAmount;
        }
        public void DecramentInventory(int newAmount)
        {
            amount -= newAmount;
        }
    }
}
