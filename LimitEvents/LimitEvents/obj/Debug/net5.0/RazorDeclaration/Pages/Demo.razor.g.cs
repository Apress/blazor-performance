// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LimitEvents.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Code\GitHub\Apress.Videos.Performance\LimitEvents\LimitEvents\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\GitHub\Apress.Videos.Performance\LimitEvents\LimitEvents\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\GitHub\Apress.Videos.Performance\LimitEvents\LimitEvents\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\GitHub\Apress.Videos.Performance\LimitEvents\LimitEvents\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Code\GitHub\Apress.Videos.Performance\LimitEvents\LimitEvents\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Code\GitHub\Apress.Videos.Performance\LimitEvents\LimitEvents\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Code\GitHub\Apress.Videos.Performance\LimitEvents\LimitEvents\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Code\GitHub\Apress.Videos.Performance\LimitEvents\LimitEvents\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Code\GitHub\Apress.Videos.Performance\LimitEvents\LimitEvents\_Imports.razor"
using LimitEvents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Code\GitHub\Apress.Videos.Performance\LimitEvents\LimitEvents\_Imports.razor"
using LimitEvents.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Code\GitHub\Apress.Videos.Performance\LimitEvents\LimitEvents\_Imports.razor"
using Blazor.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Code\GitHub\Apress.Videos.Performance\LimitEvents\LimitEvents\_Imports.razor"
using Blazor.Extensions.Canvas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Code\GitHub\Apress.Videos.Performance\LimitEvents\LimitEvents\_Imports.razor"
using Blazor.Extensions.Canvas.Canvas2D;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Code\GitHub\Apress.Videos.Performance\LimitEvents\LimitEvents\_Imports.razor"
using Blazor.Extensions.Canvas.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Code\GitHub\Apress.Videos.Performance\LimitEvents\LimitEvents\Pages\Demo.razor"
using Excubo.Blazor.Canvas;

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
#line 20 "C:\Code\GitHub\Apress.Videos.Performance\LimitEvents\LimitEvents\Pages\Demo.razor"
       

  private ElementReference canvas;

  private int countMoves = 0;
  private int color = 0;

  private async Task OnMouseMove(MouseEventArgs e)
  {
    var mouse_x = e.OffsetX;
    var mouse_y = e.OffsetY;

    countMoves += 1;
    await using (var context = await this.js.GetContext2DAsync(canvas))
    {
      await context.BeginPathAsync();
      await context.MoveToAsync(0, 0);
      await context.LineToAsync(mouse_x, mouse_y);
      await context.StrokeStyleAsync(colors[color]);
      color = (color + 1) % colors.Length;
      await context.StrokeAsync();
      await context.ClosePathAsync();
    }
  }

  private string[] colors = new string[]
  {
    "blue",
    "blue-violet",
    "auburn",
    "cadet blue",
    "chartreuse",
    "dark goldenrod",
    "dark cyan",
    "dark blue",
    "aqua",
    "crimson",
    "cornflower blue",
    "chocolate",
    "chartreuse",
    "green",
    "dark slate blue",
    "dark sea green",
    "dark orchid",
    "dark orange",
    "dark magenta",
    "dark khaki",
    "dark gray"
  };

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.JSInterop.IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
