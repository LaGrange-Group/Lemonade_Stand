using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class WeatherAPI
    {
        public static void CallAPI()
        {
            var result = GetGameData("&APPID=53583c9b07dd076ba75bd54bd5dcc3bd").Result;

            //TODO parse json here. For example, see http://stackoverflow.com/questions/6620165/how-can-i-parse-json-with-c

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static async Task<string> GetGameData(string id)
        {
            var url = "http://api.openweathermap.org/data/2.5/weather?q=Milwaukee&units=imperial" + id;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string strResult = await response.Content.ReadAsStringAsync();

                    return strResult;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
