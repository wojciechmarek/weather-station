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
    /// <summary>
    /// Klasa implementująca metody do obsługi zapytań do serwera
    /// </summary>
    public class DataAccessServices : IDataAccessServices
    {
        Services services = new Services();

        /// <summary>
        /// Funkcja obsługi zapytania o prognozę pogody
        /// </summary>
        /// <param name="callback">Obiekt zwrotny zawierający zmapowane dane pogody i ewentualne obiekt błędów</param>
        /// <param name="CityName">Nazwa miejscowości do wyszukania</param>
        public void GetForecast(Action<Forecast, Exception> callback, string CityName)
        {
           var item = services.GetForecast(CityName, (error) => callback(null, error));
            if (item != null)
            {
                callback(item, null);
            }
        }

        /// <summary>
        /// Funkcja obsługi zapytania o prognozę pogody
        /// </summary>
        /// <param name="callback">Obiekt zwrotny zawierający zmapowane dane pogody i ewentualne obiekt błędów</param>
        /// <param name="CityName">Nazwa miejscowości do wyszukania</param>
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
