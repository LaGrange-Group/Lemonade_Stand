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
        private static void DisplayPastDayData(Game game)
        {
            if (game.currentDay > 1)
            {
                Console.Clear();
                DisplayGameInfo("dayresults");
                StoredResults(game);
                BackToMain(game);
            }
        }
        private static void StoredResults(Game game)
        {
            for (int i = 0; i < game.dayResultsData.Count; i++)
            {
                foreach (string data in game.dayResultsData[i])
                {
                    Console.Write(data);
                }
                Console.WriteLine("\n\n");
            }
        }
        private static void BackToMain(Game game)
        {
            Console.WriteLine("\n(1) to go back to menu");
            try
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        game.ShowMenu();
                        return;
                    default:
                        DisplayInvalid();
                        StoredResults(game);
                        return;
                }
            }
            catch
            {
                DisplayInvalid();
                StoredResults(game);
                return;
            }
        }
        public static void DisplayGameEnd(Game game)
        {
            Console.Clear();
            DisplayGameInfo("endgame");
            StoredResults(game);
            RestartOrQuit(game);
        }
        public static void PlayerActions(Player player, Store store, Game game, Day day)
        {
            try
            {
                if (game.currentDay == 1)
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
                else
                {
                    Console.WriteLine("\n--Actions-- \n\n(1) to visit store\n(2) to set recipe\n(3) to create lemonade\n(4) to start simulation for day\n(5) to display previous days results + info ");
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
                        case 5:
                            DisplayPastDayData(game);
                            break;
                        default:
                            DisplayInvalid();
                            PlayerActions(player, store, game, day);
                            return;
                    }
                }
            }
            catch
            {
                DisplayInvalid();
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
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                DisplayInvalid();
                return SetDaysToPlay();
            }
        }
        public static void DisplayDayConclusion(double startingMoney, double endMoney, double percentDiff, int amountOfCustomers, int bought, double totalProfit)
        {
            Console.WriteLine("\nToday you had " + amountOfCustomers + " customers. Out of " + amountOfCustomers + ", " + bought + " decided to buy. " + "\nYou started the day with ${0:00.00}. You ended the day with ${1:00.00}. That is a {2:00.00}% difference!\nTotal profit made from lemonade stand: {3:00.00}" , startingMoney, endMoney, percentDiff, totalProfit);
        }
        private static void RestartOrQuit(Game game)
        {
            Console.WriteLine("\nWould you like to play again or exit? (1) for exit || (2) for replay");
            try
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Environment.Exit(0);
                        return;
                    case 2:
                        game.StartGame();
                        return;
                    default:
                        DisplayInvalid();
                        RestartOrQuit(game);
                        return;
                }
            }
            catch
            {
                DisplayInvalid();
                RestartOrQuit(game);
                return;
            }

        }
        public static void DisplayGameInfo(string thisCase)
        {
            switch (thisCase)
            {
                case "welcome":
                    Console.Clear();
                    Console.WriteLine("Welcome to Lemonade Stand!");
                    break;
                case "main":
                    Console.WriteLine("--Main Menu--");
                    break;
                case "continue":
                    Console.WriteLine("\nThe rest of your ice has melted!\n");
                    Console.WriteLine("Are you ready to continue to the next day? (Hit enter to continue)");
                    Console.ReadLine();
                    break;
                case "dayresult":
                    Console.WriteLine("--Past Days Results--\n\n");
                    break;
                case "endgame":
                    Console.WriteLine("--End of Game Results--\n\n");
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
        public static void AskIfNeedRules(Game game)
        {
            Console.WriteLine("\nWould you like to review the rules? (1) for yes || (2) for no");
            try
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        DisplayRules(game);
                        break;
                    case 2:
                        return;
                    default:
                        DisplayInvalid();
                        AskIfNeedRules(game);
                        return;
                }
            }
            catch
            {
                DisplayInvalid();
                AskIfNeedRules(game);
                return;
            }
        }
        private static void DisplayRules(Game game)
        {
            Console.Clear();
            Console.WriteLine("--Rules--");
            Console.WriteLine("\nLemonade stand is played by one or more players.\nEach player has an inventory consisting of: \nLemons\nSugar\nIce\nCups\nYou must create a recipe that will be used to create a pitcher of lemonade.\nOnce you have created your first pitcher, you can start\nthe simulation where customers will make a choice to purchase your \nlemonade based on the weather, cost of a glass, and quality of recipe.\nYou will choose how many days you would like to play.\nGood luck and have fun!");
            Console.WriteLine("\n\nAre you ready to start? (1) to start || (2) to quit");
            try
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        return;
                    case 2:
                        Environment.Exit(0);
                        return;
                    default:
                        DisplayInvalid();
                        DisplayRules(game);
                        break;
                }
            }
            catch
            {
                DisplayInvalid();
                DisplayRules(game);
                return;
            }
        }
    }
}
