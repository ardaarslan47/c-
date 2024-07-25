using System;

namespace lambda
{
  internal class Program
  {
    public delegate bool FilterDelegate(int p);
    public static void Main()
    {
      Console.WriteLine("Hello World");

      FilterDelegate isGreaterThan20 = (p) => p > 20; 
      Console.WriteLine("1: " + filterNumber(25, isGreaterThan20).ToString());
      Console.WriteLine("2: " + filterNumber(30, p => p < 10).ToString());
      Console.WriteLine("3: " + filterNumber(0, p => p != 0).ToString());
  }

    public static bool filterNumber(int i, FilterDelegate filter)
    {
      return filter(i);
    } 







  }
}
