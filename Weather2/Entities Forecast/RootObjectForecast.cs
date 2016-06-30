using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Weather2
{
    public class RootObject
    {
        public CityForecast city { get; set; }
        public string cod { get; set; }
        public double message { get; set; }
        public int cnt { get; set; }
        public List<ListForecast> list { get; set; }
    }
}


