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
        public Item lemons;
        public Item sugar;
        public Item ice;
        public Item cups;
        private List<Item> inventory;
        private string name;
        private double preDayMoney;
        public double totalProfit;
        public double PreDayMoney
        {
            get
            {
                return preDayMoney;
            }
            set
            {
                preDayMoney = value;
            }
        }

        public Player()
        {
            inventory = new List<Item>();
            inventory.Add(lemons = new Lemon());
            inventory.Add(sugar = new Sugar());
            inventory.Add(ice = new Ice());
            inventory.Add(cups = new Cup());
            wallet = new Wallet();
        }
        public void SetName()
        {
            UI.DisplayGameInfo("welcome");
            Console.WriteLine("\nPlease enter your name..");
            name = Console.ReadLine();
        }
        public void SetRecipe(Game game)
        {
            recipe = new Recipe();
            recipe.RecipeStart();
            game.ShowMenu();
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
            game.ShowMenu();
        }
        public double FindWalletDifference(double start, double end)
        {
            double diff = end - start;
            diff = (diff / start) * 100;
            return diff;
        }
        public void FindTotalProfit(double dayProfit)
        {
            totalProfit += dayProfit;
        }
    }
}
