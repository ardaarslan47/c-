using System;

namespace TempMonitor
{
  public delegate void TempratureChangeHandler(string message);

  public class TempratureMonitor
  {
    public event TempratureChangeHandler OnTempratureChange;

    private int _temprature;

    public int Temprature { get => _temprature ; set {
       _temprature = value;
       if (value > 30)
       {
         RaiseTempratureChangeEvent("temprature is over 30 degree");
       }
      }
    }

    protected virtual void RaiseTempratureChangeEvent(string message)
    {
       OnTempratureChange?.Invoke(message);
    }
  }

  public class TempratureAlert
  {
    public void OnTempratureChange(string message)
    {
      Console.WriteLine("alert: {0}", message);
    }
  }

  internal class Program
  {


    public static void Main()
    {
      TempratureMonitor monitor = new TempratureMonitor();
      TempratureAlert alert = new TempratureAlert();

      monitor.OnTempratureChange += alert.OnTempratureChange;

      monitor.Temprature = int.Parse(Console.ReadLine());
    }
  }
}
