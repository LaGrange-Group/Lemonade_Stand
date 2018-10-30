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
        public void SetRecipe(Game game)
        {
            recipe = new Recipe();
            recipe.RecipeStart();
            game.PlayerMenu();
        }
        public void CreateLemonade(Recipe recipe, Game game)
        {
            if (recipe != null && recipe.recipeSet == true)
            {
                pitcher = new Pitcher(this);
                pitcher.CreateLemonade();
            }
            else
            {
                Console.WriteLine("\nYou need to set a recipe before you can create lemonade! (Hit enter to continue)");
                Console.ReadLine();
            }
            game.PlayerMenu();
        }
    }
}
