using System;

namespace Calculator
{
  class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the calculator app");
      Console.WriteLine("Enter first number");
      int num1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter second number");
      int num2 = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter operator('+', '-', '*', '/')");
      string op = Console.ReadLine();

      switch (op)
      {
        case "+":
          Console.WriteLine(num1 + num2);
          break;
        case "-":
          Console.WriteLine(num1 - num2);
          break;
        case "*":
          Console.WriteLine(num1 * num2);
          break;
        case "/":
          Console.WriteLine(num1 / num2);
          break;
        default: 
          Console.WriteLine("Invalid Operator");
          break;
      }
    }
  }
}
