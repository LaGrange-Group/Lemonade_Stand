using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class AI
    {
        private Weather weather;
        private Player player;
        private Random random;
        public AI(Weather weather, Player player)
        {
            random = new Random();
            this.weather = weather;
            this.player = player;
        }
        public bool RunAI()
        {
            return MakeChoice(FindRandomNumberRangeForChoice(FindAveragePercent(FindScore(), DayConditionPercent())));
        }
        private int FindAveragePercent(int percentOne, int percentTwo)
        {
            int percent;
            percent = (percentOne + percentTwo) / 2;
            return percent;
        }
        private int FindRandomNumberRangeForChoice(int percent)
        {
            if (percent >= 75)
            {
                return random.Next(3, 10);
            }else if(percent >= 50)
            {
                return random.Next(2, 10);
            }else if(percent > 25)
            {
                return random.Next(0, 10);
            }
            else
            {
                return random.Next(0, 8);
            }
        }
        private bool MakeChoice(int factor)
        {
            if (factor >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int DayConditionPercent()
        {
            switch (weather.DayCondition)
            {
                case "Sunny":
                    return 100;
                case "Overcast":
                    return 70;
                case "Rainy":
                    return 50;
                case "Stormy":
                    return 30;
                case "Mixed":
                    return random.Next(20, 80);
                default:
                    Console.WriteLine("\nError in setting day condition. Game is broken!");
                    return 0;
            }
        }
        private int FindScore()
        {
            int score = 0;
            score += TemperatureScore();
            score += PriceScore();
            score += RecipeQualityScore();
            return CalculateScorePercent(score, 3);
        }
        private int CalculateScorePercent(int score, int highestPossScore)
        {
            int percent;
            percent = score / highestPossScore;
            percent *= 100;
            return percent;
        }
        private int TemperatureScore()
        {
            if (weather.Temperature >= 90)
            {
                if(player.recipe.IceGet >= 5)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }else if (weather.Temperature >= 75)
            {
                if (player.recipe.IceGet >= 4)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else if (weather.Temperature >= 50)
            {
                if (player.recipe.IceGet >= 3)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else if (weather.Temperature < 50)
            {
                if (player.recipe.IceGet >= 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            Console.WriteLine("Weather temerature error! Warning, game broken!");
            return 0;
        }
        private int PriceScore()
        {
            if (weather.Temperature >= 90)
            {
                if (player.pitcher.PriceOfGlass < 0.50)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else if (weather.Temperature >= 75)
            {
                if (player.pitcher.PriceOfGlass < 0.35)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else if (weather.Temperature >= 50)
            {
                if (player.pitcher.PriceOfGlass < 0.25)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else if (weather.Temperature < 50)
            {
                if (player.pitcher.PriceOfGlass < 0.20)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            Console.WriteLine("Price of glass error! Warning, game broken!");
            return 0;
        }
        private int RecipeQualityScore()
        {
            if (player.pitcher.TasteQuality == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
