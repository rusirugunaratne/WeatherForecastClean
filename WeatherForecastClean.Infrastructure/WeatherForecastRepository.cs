using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecastClean.Application;
using WeatherForecastClean.Core;

namespace WeatherForecastClean.Infrastructure
{
    public class WeatherForecastRepository : IWeatherForecastRepository
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        
        public WeatherForecast[] GetWeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1,5).Select(index=> new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC= rng.Next(-20,55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray();
        }
    }
}
