using System.Net.Http;
using System.Threading.Tasks;
using Challenge1_2.Models;
using Newtonsoft.Json;

namespace Challenge1_2.Helpers
{
    public class CityHelper
    {

        const string API = "maps.googleapis.com/maps/api/place/autocomplete/json?input=";
        const string APIKEY = "&types=(cities)&key=AIzaSyDQ0Zzrac5HUEw0_j0O8XaVW9_e-EDGVag";

        public static async Task<CityInformation> GetCurrentCity (string city)
        {
            string url = $"http://{API}{city}{APIKEY}";

            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(url);
            var result = JsonConvert.DeserializeObject<WeatherInformation.ResponseWeather>(response);
            return result;
        }
    }
}
