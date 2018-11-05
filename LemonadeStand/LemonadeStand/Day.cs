using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        public Weather weather;
        private Player player;
        private Customer customer;
        public int bought;
        public int amountOfCustomers;


        public Day(Player player)
        {
            this.player = player;
            weather = new Weather();
            bought = 0;
        }

        public void DailyCustomers()
        {
            amountOfCustomers = UI.random.Next(30, 150);
            int i = 0;
            while (i < amountOfCustomers){
                customer = new Customer(weather, player, UI.random);
                customer.DecisionToBuy(this);
                UI.PreviousCustomerDetails(customer);
                i++;
            }
        }
    }
}
