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
        public double temp { get; set; }
        public double pressure { get; set; }
        public int humidity { get; set; }
        public string icon { get; set; }
        public string dt_txt { get; set; }
    }
}
