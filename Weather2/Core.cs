using System.Threading.Tasks;

namespace Weather2
{
    public class Core
    {
        #region fields
        const string WEATHER_API_Forecast = "http://api.openweathermap.org/data/2.5/weather?zip=";
        const string WEATHER_API = "http://api.openweathermap.org/data/2.5/weather?zip=";
        const string KEY = "21c650cbe3d93fb5404e056af187120d";
        const double KtoC = 273.15;


        #endregion

        #region public methods

        public static async Task<Weather> GetWeather(string zipcode)
        {
            string queryString = WEATHER_API + zipcode + "&appid=" + KEY;


            WeatherData result = await DataService.getDataFromService(queryString).ConfigureAwait(false);

            if (result != null && result.cod == 200)
            {
                Weather weather = new Weather();
                weather.Title = result.name;
                weather.Temperature = result.main.temp-KtoC + "º";
                weather.TempMin = result.main.temp_min- KtoC + "º";
                weather.TempMax = result.main.temp_max- KtoC + "º";
                weather.Press = result.main.pressure;
                weather.Hum = result.main.humidity;
                weather.Win = result.wind.speed ;
                weather.Img = string.Concat("http://openweathermap.org/img/w/", result.weather[0].icon, ".png");
                return weather;
            }
            else {
                
                return null;

            }

        }

        public static async Task<Weather2> GetWeatherForecast(string zipcode)
        {
            string queryString = WEATHER_API + zipcode + "&appid=" + KEY;
            string queryStringForecast = WEATHER_API_Forecast + zipcode + "&appid=" + KEY;

            WeatherData results = await DataService.getDataFromService(queryString).ConfigureAwait(false);
            ListForecast result = await DataService.getDataFromServiceForecast(queryStringForecast).ConfigureAwait(false);

            if (result != null && results.cod ==200)
            {
                Weather2 weather2 = new Weather2();
                weather2.Temperature2 = result.main.temp-KtoC ;
                weather2.Img2 = string.Concat("http://openweathermap.org/img/w/", result.weather[0].icon, ".png");
                weather2.Date = result.dt_txt;
                return weather2;
            }
            else {

                return null;

            }

        }

        #endregion
    }
}
