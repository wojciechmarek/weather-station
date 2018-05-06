using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Model.Mappings;

namespace WeatherStation.Model.Services
{

    public class Services
    {
        const string API_KEY = "06c772d9626be9e6298e5a2f2c912935";


        public Today GetTodayWeather(string cityName)
        {
            var querry = string.Format($@"http://api.openweathermap.org/data/2.5/weather?q={cityName}&APPID={API_KEY}");
            var jsonData = GetJsonString(querry).Result;
            Today today = JsonConvert.DeserializeObject<Today>(jsonData);
            return today;
        }

        public Forecast GetForecast(string cityName)
        {
            var querry = string.Format($@"http://api.openweathermap.org/data/2.5/forecast?q={cityName}&APPID={API_KEY}");
            var jsonData = GetJsonString(querry).Result;
            Forecast forecast = JsonConvert.DeserializeObject<Forecast>(jsonData);
            return forecast;
        }

        private async Task<string> GetJsonString(string querry)
        {
            HttpClient httpClient = new HttpClient();
            return await Task.Run(() =>
            {
               return httpClient.GetStringAsync(querry);
            });
        }



    }
}
