using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        private Weather weather;
        private Customer customer;
        private Random random;
        private Recipe recipe;
        private Pitcher pitcher;


        public Day(Recipe recipe, Pitcher pitcher)
        {
            this.recipe = recipe;
            this.pitcher = pitcher;
            weather = new Weather();
            random = new Random();
        }

        public void DailyCustomers()
        {
            int amountOfCustomers = random.Next(30, 150);
            int i = 0;
            while (i < amountOfCustomers){
                Customer customer = new Customer(weather, );
            }
        }
    }
}
