using Lab27_API_MVC_combo.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab27_API_MVC_combo.Services
{
    public class ApiWeatherService : IWeatherService
    {
        private readonly HttpClient _client;

        public ApiWeatherService(HttpClient client)
        {
            _client = client;
        }
        public async Task<Weather> GetWeather(string coordinates)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true
            };

            var response = await _client.GetFromJsonAsync<Weather>(coordinates, options);

            return response;
        }
    }
}
