using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ServiceProxies
{
  public class WeatherForecastService : IWeatherForecastService
  {
    private readonly HttpClient httpClient;

    public WeatherForecastService(HttpClient httpClient) => this.httpClient = httpClient;

    public async ValueTask<IEnumerable<WeatherForecast>> GetWeatherForecasts()
    {
      WeatherForecast[] forecasts = 
        await this.httpClient.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
      return forecasts.AsEnumerable();
    }
  }
}
