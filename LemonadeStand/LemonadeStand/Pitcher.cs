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
            player.lemons.DecramentInventory(recipe.Lemons);
            player.sugar.DecramentInventory(recipe.Sugar);
            player.ice.DecramentInventory(recipe.Ice);
            SetTaste();
        }
        private void SetTaste()
        {
            if (recipe.Lemons - recipe.Sugar > 1 || recipe.Lemons - recipe.Sugar < -1)
            {
                tasteQuality = false;
            }
            else
            {
                tasteQuality = true;
            } 
        }
        public void DecramentCups()
        {
            cups--;
        }
    }
}
