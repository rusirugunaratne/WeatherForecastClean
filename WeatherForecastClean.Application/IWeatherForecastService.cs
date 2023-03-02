using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecastClean.Core;

namespace WeatherForecastClean.Application
{
    public interface IWeatherForecastService
    {
        List<WeatherForecast> ProcessFTemperature();
    }
}
