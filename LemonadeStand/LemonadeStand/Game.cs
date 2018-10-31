using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        private Day day;
        private Player player;
        private Store store;
        public int amountOfDays;
        public int currentDay;

        public Game()
        {
            player = new Player();
            store = new Store(player);
            day = new Day(player);
            currentDay = 1;
        }
        public void StartGame()
        {
            UI.DisplayGameInfo("welcome");
            player.SetName();
            amountOfDays = UI.SetDaysToPlay();
            ShowMenu();
        }
        public void ShowMenu()
        {
            UI.PlayerMenu(player, this, store, day);
        }

        
        public void CheckIfReadyToSimulate()
        {
            if (player.recipe.recipeSet == true && player.pitcher.createdLemonade == true && player.cups.amount != 0)
            {
                SimulateDay();
            }
            else
            {
                UI.CheckWhyFail(player);
            }
        }
        public void SimulateDay()
        {
            day.DailyCustomers();
            CalculateForDayConclusion();
            Console.ReadLine();
            ShowMenu();
        }
        private void CalculateForDayConclusion()
        {
            // Put in list + use list for UI layout/param plug in + pass in day
            double percentDiff = player.FindWalletDifference(player.PreDayMoney, player.wallet.Money);
            int amountOfCustomers = day.amountOfCustomers;
            int amountWhoBought = day.bought;
            UI.DisplayDayConclusion(player.PreDayMoney ,percentDiff, amountOfCustomers, amountWhoBought);
        }



    }
}
