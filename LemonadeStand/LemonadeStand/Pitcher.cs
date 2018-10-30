using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Pitcher
    {
        private Player player;
        private double priceOfGlass;
        private bool tasteQuality;
        private int cups;
        public bool createdLemonade;
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
        public double PriceOfGlass
        {
            get
            {
                return priceOfGlass;
            }
        }
        public Pitcher(Player player)
        {
            createdLemonade = false;
            this.player = player;
        }
        public void CreateLemonade()
        {
            if(player.lemons.CheckForValidAmount(player.recipe.LemonsGet) == true && player.sugar.CheckForValidAmount(player.recipe.SugarGet) == true && player.ice.CheckForValidAmount(player.recipe.IceGet) == true)
            {
                player.lemons.DecramentInventory(player.recipe.LemonsGet);
                player.sugar.DecramentInventory(player.recipe.SugarGet);
                player.ice.DecramentInventory(player.recipe.IceGet);
                cups = 12;
                SetTaste();
            }
            else
            {
                Console.WriteLine("\nCheck you inventory and check you recipe. You need more stuff to start! Ok? (Hit enter to continue back to main menu)");
                Console.ReadLine();
                return;
            }

        }
        private void SetTaste()
        {
            if (player.recipe.LemonsGet - player.recipe.SugarGet > 1 || player.recipe.LemonsGet - player.recipe.SugarGet < -1)
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
            priceOfGlass = Convert.ToDouble(Console.ReadLine());
            if (priceOfGlass >= 0.01 && priceOfGlass <= 100)
            {
                createdLemonade = true;
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
