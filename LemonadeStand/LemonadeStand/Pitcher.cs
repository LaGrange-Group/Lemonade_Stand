using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Pitcher
    {
        private Recipe recipe;
        private Player player;
        private double priceOfGlass;
        private bool tasteQuality;
        private int cups;
        public int Cups
        {
            get
            {
                return cups;
            }
        }
        public bool TasteQuality
        {
            get
            {
                return tasteQuality;
            }
        }
        public Pitcher(Recipe recipe, Player player)
        {
            this.recipe = recipe;
            this.player = player;
        }
        public void CreateLemonade()
        {
            player.lemons.DecramentInventory(recipe.LemonsGet);
            player.sugar.DecramentInventory(recipe.SugarGet);
            player.ice.DecramentInventory(recipe.IceGet);
            SetTaste();
        }
        private void SetTaste()
        {
            if (recipe.LemonsGet - recipe.SugarGet > 1 || recipe.LemonsGet - recipe.SugarGet < -1)
            {
                tasteQuality = false;
            }
            else
            {
                tasteQuality = true;
            }
            SetPrice();
        }
        private void SetPrice()
        {
            Console.WriteLine("\nYou've made your first pitcher of the day! \n\nHow much would you like to charge per glass of your lemonade? (Ex. 0.25) min: 0.01 max: 100.00 ");
            priceOfGlass = Convert.ToInt32(Console.ReadLine());
            if (priceOfGlass >= 0.01 && priceOfGlass <= 100)
            {
                return;
            }
            else
            {
                Console.WriteLine("\nYou have entered an invalid input. Please try again.");
                SetPrice();
                return;
            }
        }
        public void DecramentCups()
        {
            cups--;
        }
    }
}
