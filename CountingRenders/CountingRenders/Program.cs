using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Components.WebAssembly.Services;
using Microsoft.Extensions.DependencyInjection;
using ServiceProxies.LazyLoading;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CountingRenders
{
  public class Program
  {
    public static async Task Main(string[] args)
    {
      var builder = WebAssemblyHostBuilder.CreateDefault(args);
      builder.RootComponents.Add<App>("#app");

      builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

      builder.Services.AddScoped<LazyAssemblyLoader>();
      builder.Services.AddScoped<LazyLoadedWeatherForecastService>();

      await builder.Build().RunAsync();
    }
  }
}
