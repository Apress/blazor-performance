using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;

namespace ServiceProxies.LazyLoading
{
  public class LazyLoadedWeatherForecastService
  {
    private readonly IServiceProvider services;

    public LazyLoadedWeatherForecastService(IServiceProvider services) => this.services = services;

    public IWeatherForecastService Create()
    {
      HttpClient http = this.services.GetRequiredService<HttpClient>();
      return new WeatherForecastService(http);
    }
  }
}
