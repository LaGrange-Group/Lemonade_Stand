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
        private int amountOfDays;
        private int currentDay;

        public Game()
        {
            player = new Player();
            store = new Store(player);
            day = new Day(player);
            currentDay = 1;
        }
        public void StartGame()
        {
            DisplayGameInfo("welcome");
            player.SetName();
            SetDaysToPlay();
        }
        public void PlayerMenu()
        {
            Console.Clear();
            Console.WriteLine("--Main Menu--");
            DisplayInventory();
            DisplayWeather(day.weather);
            PlayerActions();
            Console.ReadLine();
        }
        private void PlayerActions()
        {
            Console.WriteLine("\n--Actions-- \n\n(1) to visit store\n(2) to set recipe\n(3) to create lemonade\n\n(4) to start simulation for day " + currentDay);
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    store.EnterStore(this);
                    break;
                case 2:
                    player.SetRecipe(this);
                    break;
                case 3:
                    player.CreateLemonade(player.recipe, this);
                    break;
                case 4:
                    // Start Simulation
                    break;
                default:
                    Console.WriteLine("You have entered an invalid input. Please try again.");
                    PlayerActions();
                    return;
            }
        }
        private void SetDaysToPlay()
        {
            Console.WriteLine("\nHow many days would you like to play for?");
            amountOfDays = Convert.ToInt32(Console.ReadLine());
            PlayerMenu();
        }
        private void DisplayGameInfo(string thisCase)
        {
            switch (thisCase)
            {
                case "welcome":
                    Console.WriteLine("Welcome to Lemonade Stand!");
                    break;
                default:
                    break;
            }
        }
        public void DisplayInventory()
        {
            Console.WriteLine("\n--Inventory--\nMoney: $" + player.wallet.Money + "\nLemons: " + player.lemons.amount + "\nCups of sugar: " + player.sugar.amount + "\nPieces of ice: " + player.ice.amount + "\nCups: " + player.cups.amount + "\n\nDay: " + currentDay + " / " + amountOfDays );
        }
        private void DisplayWeather(Weather weather)
        {
            Console.WriteLine("\n\n--Weather--\nWeather Condition: " + weather.DayCondition + "\nTemperature: " + weather.Temperature);
        }
    }
}
