using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Model.Mappings;

namespace WeatherStation.Model.Services
{
    public interface IDataAccessServices
    {
        void GetToday(Action<Today, Exception> callback, string CityName);
        void GetForecast(Action<Forecast, Exception> callback, string CityName);
    }
}
