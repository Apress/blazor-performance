using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProxies
{
  public interface IWeatherForecastService
  {
    ValueTask<IEnumerable<WeatherForecast>> GetWeatherForecasts();
  }
}
