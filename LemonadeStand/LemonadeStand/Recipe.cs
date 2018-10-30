using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        private int lemons;
        private int sugar;
        private int ice;
        public int Lemons
        {
            get
            {
                return lemons;
            }
        }
        public int Sugar
        {
            get
            {
                return sugar;
            }
        }
        public int Ice
        {
            get
            {
                return ice;
            }
        }
        public Recipe()
        {
            RecipeStart();
        }
        public void RecipeStart()
        {
            Console.WriteLine("\nIts time to set your daily recipe!");
        }
        private void CreateRecipe()
        {
            Lemons();
            Sugar();
            Ice();
        }
        private void Lemons()
        {
            Console.WriteLine("\nHow many lemons per pitcher?");
            lemons = Convert.ToInt32(Console.ReadLine());
            Sugar();
        }
        private void Sugar()
        {
            Console.WriteLine("\nHow many cups of sugar per pitcher?");
            sugar = Convert.ToInt32(Console.ReadLine());
            Ice();
        }
        private void Ice()
        {
            Console.WriteLine("\nHow much ice per cup? (12 cups per pitcher)");
            ice = Convert.ToInt32(Console.ReadLine());
            DisplayRecipe();
        }
        private void DisplayRecipe()
        {
            Console.WriteLine("Your recipe (amount per pitcher): \nLemons: " + lemons + "\nCups of sugar: " + sugar + "\nAmount of ice: "  + ice + "\n\n To finalize your recipe for today type (1) or type (2) to restart.");
            FinalizeRestart();

        }
        private void FinalizeRestart()
        {
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    return;
                case 2:
                    RecipeStart();
                    return;
                default:
                    break;
            }
        }
    }
}
