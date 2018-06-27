using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.Model.Mappings
{
    /// <summary>
    /// Klasa mapująca prognozę pogody
    /// </summary>
    public class Forecast
    {
        public string cod { get; set; }
        public List<Weathers> list { get; set; }
    }

    /// <summary>
    /// Klasa mapująca prognozę pogody
    /// </summary>
    public class Weathers
    {
        public Main main { get; set; }
        public Weather[] weather { get; set; }
    }
}
