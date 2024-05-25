using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Weather.Repository;
using Weather.Service;

namespace Weather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly WeatherService _weatherService;
        private readonly WeatherRepository _weatherRepository;

        public WeatherController(WeatherService weatherService, WeatherRepository weatherRepository)
        {
            _weatherService = weatherService;
            _weatherRepository = weatherRepository;
        }

        [HttpGet("{location}")]
        public async Task<IActionResult> GetCurrentWeather(string location)
        {
            var weatherData = await _weatherService.GetWeatherAsync(location);
            await _weatherRepository.SaveWeatherDataAsync(weatherData);
            return Ok(weatherData);
        }
        [HttpGet("history")]
        public async Task<IActionResult> GetWeatherHistory(string location, string from, string to)
        {
            if (!DateTime.TryParse(from, out DateTime fromDate))
            {
                return BadRequest("Invalid 'from' date.");
            }

            if (!DateTime.TryParse(to, out DateTime toDate))
            {
                return BadRequest("Invalid 'to' date.");
            }

            if ((toDate - fromDate).Days > 30)
            {
                return BadRequest("Date range should not exceed 30 days.");
            }

            var weatherHistory = await _weatherRepository.GetWeatherDataAsync(location, fromDate, toDate);
            return Ok(weatherHistory);
        }
    }
}
