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
        private Random random;
        private Player player;


        public Day(Player player)
        {
            this.player = player;
            weather = new Weather();
            random = new Random();
        }

        public void DailyCustomers()
        {
            int amountOfCustomers = random.Next(30, 150);
            int i = 0;
            while (i < amountOfCustomers){
                Customer customer = new Customer(weather, player);
                customer.DecisionToBuy();
            }
        }
    }
}
