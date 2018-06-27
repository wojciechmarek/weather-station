using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Model.Mappings;

namespace WeatherStation.Model.Services
{

    public class Services
    {
        HttpClient httpClient = new HttpClient();
        string api_key = ConfigurationManager.AppSettings["private_api_key"];

        public Today GetTodayWeather(string cityName, Action<Exception> exceptionCall)
        {
            try
            {
                var url = ConfigurationManager.AppSettings["today_url"];
                var querry = string.Format(url+"{0}+&APPID={1}", cityName, api_key );
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
                var url = ConfigurationManager.AppSettings["forecast_url"];
                var querry = string.Format(url + "{0}+&APPID={1}", cityName, api_key);
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


