using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public Wallet wallet;
        private Pitcher pitcher;
        private Recipe recipe;
        public Inventory lemons;
        public Inventory sugar;
        public Inventory ice;
        public Inventory cups;
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
        private void SetRecipe()
        {
            recipe = new Recipe();
        }
    }
}
