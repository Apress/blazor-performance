// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace UsingKey.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Code\GitHub\Apress.Videos.Performance\CountingRenders\UsingKey\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\GitHub\Apress.Videos.Performance\CountingRenders\UsingKey\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\GitHub\Apress.Videos.Performance\CountingRenders\UsingKey\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\GitHub\Apress.Videos.Performance\CountingRenders\UsingKey\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Code\GitHub\Apress.Videos.Performance\CountingRenders\UsingKey\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Code\GitHub\Apress.Videos.Performance\CountingRenders\UsingKey\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Code\GitHub\Apress.Videos.Performance\CountingRenders\UsingKey\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Code\GitHub\Apress.Videos.Performance\CountingRenders\UsingKey\_Imports.razor"
using UsingKey;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Code\GitHub\Apress.Videos.Performance\CountingRenders\UsingKey\_Imports.razor"
using UsingKey.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Code\GitHub\Apress.Videos.Performance\CountingRenders\UsingKey\_Imports.razor"
using UsingKey.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/demo")]
    public partial class Demo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Code\GitHub\Apress.Videos.Performance\CountingRenders\UsingKey\Pages\Demo.razor"
       
    private List<Trainer> trainers;

    protected override async Task OnInitializedAsync()
    {
      trainers = await trainerService.GetTrainers();
    }

    public async Task Reload()
    {
      trainers = await trainerService.GetTrainers();
    }

    public void RotateTrainers()
    {
      var first = trainers.First();
      trainers.RemoveAt(0);
      trainers.Add(first);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TrainerService trainerService { get; set; }
    }
}
#pragma warning restore 1591
