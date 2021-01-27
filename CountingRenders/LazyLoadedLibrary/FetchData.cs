using Microsoft.AspNetCore.Components;
using ServiceProxies;
using ServiceProxies.LazyLoading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadedLibrary
{
  public partial class FetchData
  {
    [Inject]
    public LazyLoadedWeatherForecastService Factory { get; set; }

    //[Inject]
    //public HttpClient HttpClient { get; set; }

    private IWeatherForecastService forecastService;

    private IEnumerable<WeatherForecast> forecasts;

    protected override async Task OnInitializedAsync()
    {
      forecastService ??= Factory.Create();
      //forecastService = forecastService ?? new WeatherForecastService(HttpClient);
      forecasts = await forecastService.GetWeatherForecasts();
    }
  }
}
