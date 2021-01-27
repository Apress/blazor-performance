using Microsoft.Extensions.DependencyInjection;
using ServiceProxies;
using System;
using System.Net.Http;

namespace LazyLoaded
{
  public class LazyLoadedWeatherForecastService
  {
    private readonly IServiceProvider services;

    public LazyLoadedWeatherForecastService(IServiceProvider services)
    {
      this.services = services;
    }

    public IWeatherForecastService Create()
    {
      HttpClient http = this.services.GetRequiredService<HttpClient>();
      return new WeatherForecastService(http);
    }
  }
}
