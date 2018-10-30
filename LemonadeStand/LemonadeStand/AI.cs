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
        private Recipe recipe;
        private Pitcher pitcher;
        private Random random;
        private int dayConditionPercent;
        private int scorePercent;
        public AI(Weather weather, Recipe recipe, Pitcher pitcher)
        {
            random = new Random();
            this.weather = weather;
            this.recipe = recipe;
            this.pitcher = pitcher;
        }
        public void StartAI()
        {
            DayConditionPercent();
        }
        private void DayConditionPercent()
        {
            switch (weather.DayCondition)
            {
                case "Sunny":
                    dayConditionPercent = 100;
                    break;
                case "Overcast":
                    dayConditionPercent = 70;
                    break;
                case "Rainy":
                    dayConditionPercent = 50;
                    break;
                case "Stormy":
                    dayConditionPercent = 30;
                    break;
                case "Mixed":
                    dayConditionPercent = random.Next(20, 80);
                    break;
                default:
                    break;
            }
        }



    }
}
