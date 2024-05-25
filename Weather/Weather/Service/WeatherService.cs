using Newtonsoft.Json.Linq;
using Weather.model;

namespace Weather.Service
{
    public class WeatherService
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public WeatherService(IConfiguration configuration, HttpClient httpClient)
        {
            _configuration = configuration;
            _httpClient = httpClient;
        }

        public async Task<WeatherData> GetWeatherAsync(string location)
        {
            var apiKey = _configuration["OpenWeatherMap:ApiKey"];
            var response = await _httpClient.GetStringAsync($"https://api.openweathermap.org/data/2.5/weather?q={location}&appid={apiKey}&units=metric");
            var weatherJson = JObject.Parse(response);

            return new WeatherData
            {
                Location = location,
                Temperature = weatherJson["main"]["temp"].Value<double>(),
                Description = weatherJson["weather"][0]["description"].Value<string>(),
                Icon = weatherJson["weather"][0]["icon"].Value<string>(),
                Date = DateTime.UtcNow
            };
        }
    }
}
