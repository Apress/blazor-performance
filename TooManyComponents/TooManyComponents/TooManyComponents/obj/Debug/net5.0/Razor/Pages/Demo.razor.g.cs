#pragma checksum "C:\Code\GitHub\Apress.Videos.Performance\TooManyComponents\TooManyComponents\TooManyComponents\Pages\Demo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "603ec82ffea3e6db185271705616c3129e12644a"
// <auto-generated/>
#pragma warning disable 1591
namespace TooManyComponents.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Code\GitHub\Apress.Videos.Performance\TooManyComponents\TooManyComponents\TooManyComponents\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\GitHub\Apress.Videos.Performance\TooManyComponents\TooManyComponents\TooManyComponents\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\GitHub\Apress.Videos.Performance\TooManyComponents\TooManyComponents\TooManyComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\GitHub\Apress.Videos.Performance\TooManyComponents\TooManyComponents\TooManyComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Code\GitHub\Apress.Videos.Performance\TooManyComponents\TooManyComponents\TooManyComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Code\GitHub\Apress.Videos.Performance\TooManyComponents\TooManyComponents\TooManyComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Code\GitHub\Apress.Videos.Performance\TooManyComponents\TooManyComponents\TooManyComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Code\GitHub\Apress.Videos.Performance\TooManyComponents\TooManyComponents\TooManyComponents\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Code\GitHub\Apress.Videos.Performance\TooManyComponents\TooManyComponents\TooManyComponents\_Imports.razor"
using TooManyComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Code\GitHub\Apress.Videos.Performance\TooManyComponents\TooManyComponents\TooManyComponents\_Imports.razor"
using TooManyComponents.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Code\GitHub\Apress.Videos.Performance\TooManyComponents\TooManyComponents\TooManyComponents\_Imports.razor"
using TooManyComponents.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Code\GitHub\Apress.Videos.Performance\TooManyComponents\TooManyComponents\TooManyComponents\_Imports.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Code\GitHub\Apress.Videos.Performance\TooManyComponents\TooManyComponents\TooManyComponents\_Imports.razor"
using System.Diagnostics.CodeAnalysis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Code\GitHub\Apress.Videos.Performance\TooManyComponents\TooManyComponents\TooManyComponents\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/demo")]
    public partial class Demo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-5qdzaaaowp>Some Grid with Data</h3>\r\n<hr b-5qdzaaaowp>");
#nullable restore
#line 8 "C:\Code\GitHub\Apress.Videos.Performance\TooManyComponents\TooManyComponents\TooManyComponents\Pages\Demo.razor"
 if (data == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<TooManyComponents.Pages.Center>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<BlazorPro.Spinkit.Wave>(3);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 11 "C:\Code\GitHub\Apress.Videos.Performance\TooManyComponents\TooManyComponents\TooManyComponents\Pages\Demo.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<TooManyComponents.Pages.DemoGrid>(4);
            __builder.AddAttribute(5, "DemoData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TooManyComponents.Services.DemoData[]>(
#nullable restore
#line 14 "C:\Code\GitHub\Apress.Videos.Performance\TooManyComponents\TooManyComponents\TooManyComponents\Pages\Demo.razor"
                       data

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 15 "C:\Code\GitHub\Apress.Videos.Performance\TooManyComponents\TooManyComponents\TooManyComponents\Pages\Demo.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Code\GitHub\Apress.Videos.Performance\TooManyComponents\TooManyComponents\TooManyComponents\Pages\Demo.razor"
       

    [AllowNull]
    private DemoData[] data;

    protected override async Task OnInitializedAsync()
    {
      data = await demoService.GetDemoData();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DemoService demoService { get; set; }
    }
}
#pragma warning restore 1591
