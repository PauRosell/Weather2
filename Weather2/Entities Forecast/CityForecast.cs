using System;

using Xamarin.Forms;

namespace Weather2
{
    public class CityForecast
    {
        public int id { get; set; }
        public string name { get; set; }
        public CoordForecast coord { get; set; }
        public string country { get; set; }
        public int population { get; set; }
        public SysForecast sys { get; set; }
    }
}


