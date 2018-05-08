using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Model.Mappings;
using WeatherStation.Model.Services;

namespace WeatherStation.Model.Services
{
    public class DataAccessServices : IDataAccessServices
    {
        Services services = new Services();

        public void GetForecast(Action<Forecast, Exception> callback, string CityName)
        {
           var item = services.GetForecast(CityName, (error) => callback(null, error));
            if (item != null)
            {
                callback(item, null);
            }
        }

        public void GetToday(Action<Today, Exception> callback, string CityName)
        {
            var item = services.GetTodayWeather(CityName, (error) => callback(null, error));
            if (item != null)
            {
                callback(item, null);
            }
            
        }
    }
}
