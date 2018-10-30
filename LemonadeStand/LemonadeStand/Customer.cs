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
        private Player player;
        public bool choice;
        public string name;
        public Customer(Weather weather, Player player)
        {
            name = "Phil";
            this.weather = weather;
            this.player = player;
        }

        public void DecisionToBuy()
        {
            AI ai = new AI(weather, player);
            choice = ai.RunAI();
            if (choice == true)
            {
                GiveMoney();
                TakeCup();
            }
            else
            {
                return;
            }
        }
        private void GiveMoney()
        {
            player.wallet.IncramentMoney(player.pitcher.PriceOfGlass);
        }
        private void TakeCup()
        {
            player.pitcher.DecramentCups();
        }

    }
}
