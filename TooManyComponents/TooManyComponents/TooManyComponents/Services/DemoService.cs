using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace TooManyComponents.Services
{
  public class DemoService
  {
    private readonly HttpClient httpClient;

    public DemoService(HttpClient httpClient)
    {
      this.httpClient = httpClient;
    }

    public async Task<DemoData[]> GetDemoData()
    {
      var data = await httpClient.GetFromJsonAsync<DemoData[]>("sample-data/sample.json");
      Console.WriteLine($"Loaded {data!.Length} rows of data.");
      return data;
    }
  }
}
