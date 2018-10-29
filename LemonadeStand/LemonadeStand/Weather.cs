using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        private List<string> listOfDayConditions;
        private string dayCondition;
        private int temperature;
        private Random random;

        public string DayCondition
        {
            get
            {
                return dayCondition;
            }
        }
        public int Temperature
        {
            get
            {
                return temperature;
            }
        }
        public Weather()
        {
            listOfDayConditions = new List<string>() {"Sunny", "Overcast", "Rainy", "Stormy", "Mixed"};
            random = new Random();
            SetTypeOfDay();
        }

        private void SetTypeOfDay()
        {
            dayCondition = listOfDayConditions[random.Next(0, 4)];
            SetTemperature(dayCondition);
        }
        private void SetTemperature(string thisCase)
        {
            switch (thisCase)
            {
                case "Sunny":
                    temperature = random.Next(70, 100);
                    break;
                case "Overcast":
                    temperature = random.Next(60, 90);
                    break;
                case "Rainy":
                    temperature = random.Next(65, 80);
                    break;
                case "Stormy":
                    temperature = random.Next(50, 70);
                    break;
                case "Mixed":
                    temperature = random.Next(60, 100);
                    break;
                default:
                    break;
            }
        }
    }
}
