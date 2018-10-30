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
        private int chanceToBuy;
        public Customer(Weather weather, Player player)
        {
            this.weather = weather;
            this.player = player;
        }

        public bool FindDecisionToBuy()
        {
            AI ai = new AI(weather, player);
            return ai.RunAI();
        }

    }
}
