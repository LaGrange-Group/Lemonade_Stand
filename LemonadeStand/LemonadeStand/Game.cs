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
        private List<string> dayResultsData;
        public int amountOfDays;
        public int currentDay;

        public Game()
        {
            player = new Player();
            store = new Store(player);
            day = new Day(player);
            dayResultsData = new List<string>();
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
            if (player.recipe != null && player.pitcher != null && player.cups.amount != 0)
            {
                if (player.pitcher.createdLemonade == true)
                {
                    player.PreDayMoney = player.wallet.Money;
                    SimulateDay();
                    return;
                }
            }
            UI.CheckWhyFail(player, this);
        }
        public void SimulateDay()
        {
            day.DailyCustomers();
            CalculateForDayConclusion();
            CheckIfFinished();
        }
        private void CalculateForDayConclusion()
        {
            double percentDiff = player.FindWalletDifference(player.PreDayMoney, player.wallet.Money);
            UI.DisplayDayConclusion(player.PreDayMoney, player.wallet.Money ,percentDiff, day.amountOfCustomers, day.bought);
        }
        private void IncramentDay()
        {
            currentDay++;
        }
        private void CheckIfFinished()
        {
            if (amountOfDays == currentDay)
            {
                UI.DisplayGameEnd();
            }
            else
            {
                UI.DisplayGameInfo("continue");
                IncramentDay();
                MoveToNextDay();
            }
        }
        private void MoveToNextDay()
        {
            day = new Day(player);
            player.pitcher.createdLemonade = false;
            ShowMenu();
            return;
        }



    }
}
