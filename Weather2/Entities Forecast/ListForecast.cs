using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Weather2
{
    public class ListForecast
    {
        public int dt { get; set; }
        public MainForecast main { get; set; }
        public List<WeatherForecast> weather { get; set; }
        public CloudsForecast clouds { get; set; }
        public WindForecast wind { get; set; }
        public RainForecast rain { get; set; }
        public Sys2Forecast sys { get; set; }
        public string dt_txt { get; set; }
    }
}


