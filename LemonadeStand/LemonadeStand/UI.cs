using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UI
    {
        public static Random random = new Random();
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
        public static void DisplayGameEnd()
        {

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
        public static void DisplayStoreInfo(string thisCase)
        {
            switch (thisCase)
            {
                case "welcome":
                    Console.WriteLine("Welcome to the store!");
                    break;
                case "storeitems":
                    Console.WriteLine("\nTo view price and amounts of an item enter their relative number index. \n(1) Lemons \n(2) Sugar \n(3) Ice \n(4) Cups\n(5) Finished with the store!");
                    break;
                case "lemons":
                    Console.WriteLine("\n--Lemons--\n(1) 8 Lemons Cost: $ 8.00\n(2) 16 Lemons Cost: $ 15.00\n(3) 32 Lemons Cost: $29\n(4) Go Back ");
                    break;
                case "ice":
                    Console.WriteLine("\n--Ice--\n(1) 50 Pieces of Ice Cost: $ 3.00\n(2) 100 Pieces of Ice Cost: $ 6.00\n(3) 200 Pieces of Ice Cost: $10\n(4) Go Back");
                    break;
                case "cups":
                    Console.WriteLine("\n--Cups--\n(1) 20 Cups Cost: $ 3.00\n(2) 40 Cups Cost: $ 5.00\n(3) 100 Cups Cost: $10\n(4) Go Back");
                    break;
                case "sugar":
                    Console.WriteLine("\n--Sugar--\n(1) 4 Cups of Sugar Cost: $ 8.00\n(2) 16 Cups of Sugar Cost: $ 23.00\n(3) 32 Cups of Sugar Cost: $43\n(4) Go Back");
                    break;
                default:
                    break;
            }
        }
        public static void CheckWhyFail(Player player, Game game)
        {
            if(player.recipe == null)
            {
                Console.WriteLine("You need to come up with a recipe before you can start the day! (Hit enter to continue)");
                Console.ReadLine();
                game.ShowMenu();
            }else if(player.pitcher == null || player.pitcher.createdLemonade == false)
            {
                Console.WriteLine("You havent created a pitcher of lemonade yet. Go make one so you have something to give to your customers! (Hit enter to continue)");
                Console.ReadLine();
                game.ShowMenu();
            }
            else
            {
                Console.WriteLine("You have no cups! Go buy some so people can purchase your lemonade! (Hit enter to continue)");
                Console.ReadLine();
                game.ShowMenu();
            }
        }
        public static void DisplayInvalid()
        {
            Console.WriteLine("You have entered an invalid input. Please try again.");
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
        public static void DisplayDayConclusion(double startingMoney, double endMoney, double percentDiff, int amountOfCustomers, int bought)
        {
            Console.WriteLine("\nToday you had " + amountOfCustomers + " customers. Out of " + amountOfCustomers + ", " + bought + " decided to buy. " + "\nYou started the day with ${0:00.00}. You ended the day with ${1:00.00}. That is a {2:00.00}% difference!", startingMoney, endMoney, percentDiff);
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
                case "continue":
                    Console.WriteLine("Are you ready to continue to the next day? (Hit enter to continue)");
                    Console.ReadLine();
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
