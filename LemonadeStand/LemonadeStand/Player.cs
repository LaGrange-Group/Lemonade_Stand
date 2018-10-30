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
        public Pitcher pitcher;
        public Recipe recipe;
        public Inventory lemons;
        public Inventory sugar;
        public Inventory ice;
        public Inventory cups;
        private List<Inventory> inventory;
        private string name;

        public Player()
        {
            inventory = new List<Inventory>();
            inventory.Add(lemons = new Lemons());
            inventory.Add(sugar = new Sugar());
            inventory.Add(ice = new Ice());
            inventory.Add(cups = new Cups());
            wallet = new Wallet();
        }
        public void SetName()
        {
            Console.WriteLine("\nPlease enter your name..");
            name = Console.ReadLine();
        }
        private void SetRecipe()
        {
            recipe = new Recipe();
            recipe.RecipeStart();
            CreateLemonade(recipe);
        }
        private void CreateLemonade(Recipe recipe)
        {
            pitcher = new Pitcher(recipe, this);
            pitcher.CreateLemonade();
        }
    }
}
