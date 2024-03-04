using System;

namespace _Source.Core
{
  public class ObservableInt
  {
    private int _value;
    public Action<int> OnClick;
    public ObservableInt(int value)
    {
      _value = value;
    }
    public int Value
    {
      get { return _value; }
      set
      {
        OnClick?.Invoke(value);
        _value = value;
      }
    }
  }
}