using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.Model.Mappings
{
    public class Forecast
    {
        public string cod { get; set; }

        public List<Weathers> list { get; set; }
        
    }
    
    public class Weathers
    {
        public Main main { get; set; }
        public Weather[] weather { get; set; }
    }
}
