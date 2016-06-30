using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Weather2
{
    public class DataService
    {
        public static async Task<WeatherData> getDataFromService(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(queryString);



            string json = response.Content.ReadAsStringAsync().Result;
            WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(json);
            return weatherData;
        }
       
       
        public static async Task<ListForecast> getDataFromServiceForecast(string queryStringForecast)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(queryStringForecast);



            string json = response.Content.ReadAsStringAsync().Result;
            ListForecast weatherData2 = JsonConvert.DeserializeObject<ListForecast>(json);
            return weatherData2;
        }

    }

}

