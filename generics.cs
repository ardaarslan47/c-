using System;

namespace Generics
{
  class Program
  {
    public static void PrintArray<T>(T[] array)
    {
      foreach (T item in array)
      {
        Console.WriteLine(item);
      }
    }

    public static void Main()
    {
      int[] intArray = {1, 2, 3, 4};
      string[] stringArray = {"A", "B", "C"};

      PrintArray(intArray);
      PrintArray(stringArray);
    }
  }
}
