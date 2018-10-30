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
            PlayerMenu();
        }
        public void PlayerMenu()
        {
            Console.Clear();
            UI.DisplayGameInfo("main");
            UI.DisplayInventory(player);
            UI.DisplayDayInfo(this);
            UI.DisplayWeather(day.weather);
            UI.PlayerActions(player, store, this);
            Console.ReadLine();
        }





    }
}
