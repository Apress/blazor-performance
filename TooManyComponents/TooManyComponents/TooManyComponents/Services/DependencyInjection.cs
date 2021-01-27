using Microsoft.Extensions.DependencyInjection;

namespace TooManyComponents.Services
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddDemoService(this IServiceCollection services)
    {
      return services.AddScoped<DemoService>();
    }
  }
}
