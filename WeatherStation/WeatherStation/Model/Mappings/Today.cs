using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.Model.Mappings
{
    public class Today
    {
        public Weather[] weather { get; set; }
        public Main main { get; set; }
        public Sys sys { get; set; }
        public string Name { get; set; }
        public int cod { get; set; }
    }

    public class Weather
    {
        public string main { get; set; }
        public string icon { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }
        public double pressure { get; set; }
        public int humidity { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
    }

    public class Sys
    {
        public long sunrise { get; set; }
        public long sunset { get; set; }
        public string country { get; set; }
    }
}
