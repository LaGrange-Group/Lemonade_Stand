using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UI
    {
        public static void PlayerMenu(Player player, Game game, Store store, Day day)
        {
            Console.Clear();
            DisplayGameInfo("main");
            DisplayInventory(player);
            DisplayDayInfo(game);
            DisplayWeather(day.weather);
            PlayerActions(player, store, game, day);
            Console.ReadLine();
        }
        public static void PlayerActions(Player player, Store store, Game game, Day day)
        {
            Console.WriteLine("\n--Actions-- \n\n(1) to visit store\n(2) to set recipe\n(3) to create lemonade\n\n(4) to start simulation for day " + game.currentDay);
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    store.EnterStore(game);
                    break;
                case 2:
                    player.SetRecipe(game);
                    break;
                case 3:
                    player.CreateLemonade(player.recipe, game);
                    break;
                case 4:
                    game.CheckIfReadyToSimulate();
                    break;
                default:
                    Console.WriteLine("You have entered an invalid input. Please try again.");
                    PlayerActions(player, store, game, day);
                    return;
            }
        }
        public static void CheckWhyFail(Player player)
        {
            if(player.recipe.recipeSet != true)
            {
                Console.WriteLine("You need to come up with a recipe before you can start the day!");
            }else if(player.pitcher.createdLemonade != true)
            {
                Console.WriteLine("You havent created a pitcher of lemonade yet. Go make one so you have something to give to your customers!");
            }
            else
            {
                Console.WriteLine("You have no cups! Go buy some so people can purchase your lemonade!");
            }
        }
        public static void PreviousCustomerDetails(Customer customer)
        {
            string choiceString;
            if (customer.choice == true)
            {
                choiceString = "buy";
            }
            else
            {
                choiceString = "not buy";
            }
            Console.WriteLine(customer.name + " has decided to " + choiceString + " your lemonade.");
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
