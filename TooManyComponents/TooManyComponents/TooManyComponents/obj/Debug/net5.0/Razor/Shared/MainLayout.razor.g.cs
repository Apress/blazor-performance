#pragma checksum "C:\Code\GitHub\Apress.Videos.Performance\TooManyComponents\TooManyComponents\TooManyComponents\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf971bfcfbebc740fee1e7196aea5bb30fb32b56"
// <auto-generated/>
#pragma warning disable 1591
namespace TooManyComponents.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-9uudq0me7t");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-9uudq0me7t");
            __builder.OpenComponent<TooManyComponents.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-9uudq0me7t");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-9uudq0me7t><a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-9uudq0me7t>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-9uudq0me7t");
            __builder.AddContent(15, 
#nullable restore
#line 14 "C:\Code\GitHub\Apress.Videos.Performance\TooManyComponents\TooManyComponents\TooManyComponents\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591