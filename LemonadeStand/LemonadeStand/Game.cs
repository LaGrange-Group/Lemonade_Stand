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
        public List<List<string>> dayResultsData;
        public int amountOfDays;
        public int currentDay;

        public Game()
        {

        }
        public void StartGame()
        {
            Console.Clear();
            player = new Player();
            store = new Store(player);
            day = new Day(player);
            dayResultsData = new List<List<string>>();
            currentDay = 1;
            UI.DisplayGameInfo("welcome");
            UI.AskIfNeedRules(this);
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
            double dayProfit = player.wallet.Money - player.PreDayMoney;
            player.FindTotalProfit(dayProfit);
            UI.DisplayDayConclusion(player.PreDayMoney, player.wallet.Money ,percentDiff, day.amountOfCustomers, day.bought, player.totalProfit);
            StoreData(player.PreDayMoney, player.wallet.Money, percentDiff, day.amountOfCustomers, day.bought, player.totalProfit);
        }
        private void StoreData(double startingMoney, double endingMoney, double percentDiff, int amountOfCustomers, int amountWhoBought, double totalProfit)
        {
            List<string> result = new List<string>() {"--Day: " + currentDay + "--", "\nWeather condition: " + day.weather.DayCondition, "\nTemperature: " + day.weather.Temperature, "\nStarting money: " + startingMoney, "\nEnd of day money: " + endingMoney, "\nPercent money made or lost: " + percentDiff + " %", "\nAmount of customers: " + amountOfCustomers, "\nAmount of customers that bought: " + amountWhoBought + "\nTotal profit made from lemonade stand: " + totalProfit};
            dayResultsData.Add(result);
        }
        private void IncramentDay()
        {
            currentDay++;
        }
        private void CheckIfFinished()
        {
            if (amountOfDays == currentDay)
            {
                UI.DisplayGameEnd(this);
            }
            else
            {
                UI.DisplayGameInfo("continue");
                player.ice.amount = 0;
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
