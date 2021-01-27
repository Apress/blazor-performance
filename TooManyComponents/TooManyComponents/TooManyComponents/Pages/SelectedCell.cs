namespace TooManyComponents.Pages
{
  public class SelectedCell
  {
    private DemoCell? current;

    public DemoCell? Current
    {
      get => current;
      set
      {
        current?.StateHasChanged();
        current = value;
        current?.StateHasChanged();
      }
    }
  }
}
