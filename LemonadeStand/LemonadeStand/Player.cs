using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        private Wallet wallet;
        private Pitcher pitcher;
        private Inventory lemons;
        private Inventory sugar;
        private Inventory ice;
        private Inventory cups;
        private List<Inventory> inventory;
        private string name;

        public Player()
        {
            SetName();
            inventory = new List<Inventory>();
            inventory.Add(lemons = new Lemons());
            inventory.Add(sugar = new Sugar());
            inventory.Add(ice = new Ice());
            inventory.Add(cups = new Cups());
            wallet = new Wallet();
        }
        private void SetName()
        {
            Console.WriteLine("Please enter your name..");
            name = Console.ReadLine();
        }
    }
}
