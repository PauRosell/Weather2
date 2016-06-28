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

    }
}

