using system

namespace mainArgs
{
  class Program
  {
    static void main(string[] args)
    {
      // if args is empty this causes error
      Console.WriteLine($"Hello {args[1]}");

      // to prevent errors
      if(args.length == 0)
      {
        Console.WriteLine("Please write arguments next time");
        return;
      }
    }
  }
} 
