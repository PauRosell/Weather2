using System;
using System.Collections.Generic;

namespace Weather2
{
    public class WeatherData
    {
        public Coord coord { get; set; }
        public List<WeatherDesc> weather { get; set; }
        public string @base { get; set; }
        public Main main { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }

      
    }
}

