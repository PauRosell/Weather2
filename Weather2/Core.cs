using System.Threading.Tasks;

namespace Weather2
{
    public class Core
    {
        #region fields

        const string WEATHER_API = "http://api.openweathermap.org/data/2.5/weather?zip=";
        const string KEY = "21c650cbe3d93fb5404e056af187120d";

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
                weather.Temperature = result.main.temp + "º";
                weather.TempMin = result.main.temp_min + "º";
                weather.TempMax = result.main.temp_max+ "º";
                weather.Press = result.main.pressure;
                weather.Hum = result.main.humidity;
                weather.Win = result.wind.speed;
                weather.Img = string.Concat("http://openweathermap.org/img/w/", result.weather[0].icon, ".png");
                return weather;
            }
            else {
                return null;
            }

        }

        #endregion
    }
}
