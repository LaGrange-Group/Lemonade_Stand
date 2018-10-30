using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        private Weather weather;
        private Recipe recipe;
        private Pitcher pitcher;
        private int chanceToBuy;
        public Customer(Weather weather, Recipe recipe, Pitcher pitcher)
        {
            this.weather = weather;
            this.recipe = recipe;
            this.pitcher = pitcher;
        }

        public int FindChance()
        {

            AI ai = new AI(weather, recipe, pitcher);

            return 1;
        }

    }
}
