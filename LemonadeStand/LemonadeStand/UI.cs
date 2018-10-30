using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UI
    {
        public static void PlayerActions(Player player, Store store, Game game)
        {
            Console.WriteLine("\n--Actions-- \n\n(1) to visit store\n(2) to set recipe\n(3) to create lemonade\n\n(4) to start simulation for day " + game.currentDay);
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    store.EnterStore();
                    break;
                case 2:
                    player.SetRecipe(game);
                    break;
                case 3:
                    player.CreateLemonade(player.recipe, game);
                    break;
                case 4:
                    // Start Simulation
                    break;
                default:
                    Console.WriteLine("You have entered an invalid input. Please try again.");
                    PlayerActions(player, store, game);
                    return;
            }
        }
        public static int SetDaysToPlay()
        {
            Console.WriteLine("\nHow many days would you like to play for?");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static void DisplayGameInfo(string thisCase)
        {
            switch (thisCase)
            {
                case "welcome":
                    Console.WriteLine("Welcome to Lemonade Stand!");
                    break;
                case "main":
                    Console.WriteLine("--Main Menu--");
                    break;
                default:
                    break;
            }
        }
        public static void DisplayInventory(Player player)
        {
            Console.WriteLine("\n--Inventory--\nMoney: $" + player.wallet.Money + "\nLemons: " + player.lemons.amount + "\nCups of sugar: " + player.sugar.amount + "\nPieces of ice: " + player.ice.amount + "\nCups: " + player.cups.amount);
        }
        public static void DisplayDayInfo(Game game)
        {
            Console.WriteLine("\n\nDay: " + game.currentDay + " / " + game.amountOfDays);
        }
        public static void DisplayWeather(Weather weather)
        {
            Console.WriteLine("\n\n--Weather--\nWeather Condition: " + weather.DayCondition + "\nTemperature: " + weather.Temperature);
        }
    }
}
