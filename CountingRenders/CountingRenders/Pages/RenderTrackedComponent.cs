using Microsoft.AspNetCore.Components;
using System;

namespace CountingRenders.Pages
{
  public class RenderTrackedComponent : ComponentBase
  {
    public static int rendered = 0;

    public void WriteRenderCount() => Console.WriteLine($"{rendered}");

    protected override void OnAfterRender(bool firstRender)
    {
      base.OnAfterRender(firstRender);
      rendered += 1;
    }
  }
}
