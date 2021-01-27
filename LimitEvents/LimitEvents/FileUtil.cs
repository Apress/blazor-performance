﻿using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace LimitEvents
{
  public static class FileUtil
  {
    public async static Task SaveAs(IJSRuntime js, string filename, byte[] data)
    {
      await js.InvokeAsync<object>(
          "saveAsFile",
          filename,
          Convert.ToBase64String(data));
    }
  }
}
