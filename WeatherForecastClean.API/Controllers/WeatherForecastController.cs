using Microsoft.AspNetCore.Mvc;
using WeatherForecastClean.Application;

namespace WeatherForecastClean.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _service;
        private readonly ILogger<WeatherForecastController> _logger;
        
        
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            var result = _service.ProcessFTemperature();
            return Ok(result);
        }
    }
}