// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LazyLoadingComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Code\GitHub\Apress.Videos.Performance\LazyLoading\src\LazyLoadingComponents\_Imports.razor"
using ServiceProxies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\GitHub\Apress.Videos.Performance\LazyLoading\src\LazyLoadingComponents\_Imports.razor"
using LazyLoadingComponents;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Code\GitHub\Apress.Videos.Performance\LazyLoading\src\LazyLoadingComponents\FetchData.razor"
       
    private IEnumerable<WeatherForecast> forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await factory.Create().GetWeatherForecasts();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LazyLoaded.LazyLoadedWeatherForecastService factory { get; set; }
    }
}
#pragma warning restore 1591
