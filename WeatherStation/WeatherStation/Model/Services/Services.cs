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

        HttpClient httpClient = new HttpClient();

        public Today GetTodayWeather(string cityName, Action<Exception> exceptionCall)
        {
            try
            {
                var querry = string.Format($@"http://api.openweathermap.org/data/2.5/weather?q={cityName}&APPID={API_KEY}");
                var jsonData = httpClient.GetStringAsync(querry).Result;
                Today today = JsonConvert.DeserializeObject<Today>(jsonData);
                return today;
            }
            catch (Exception ex)
            {
                exceptionCall(ex);
                return null;
            }
            
        }



        public Forecast GetForecast(string cityName, Action<Exception> exceptionCall)
        {
            try
            {
                var querry = string.Format($@"http://api.openweathermap.org/data/2.5/forecast?q={cityName}&APPID={API_KEY}");
                var jsonData = httpClient.GetStringAsync(querry).Result;
                Forecast forecast = JsonConvert.DeserializeObject<Forecast>(jsonData);
                return forecast;
            }
            catch (Exception ex)
            {
                exceptionCall(ex);
                return null;
            }

        }
    }
}   


