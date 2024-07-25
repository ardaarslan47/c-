using system

namespace userInput
{
  class Program
  {
    static void main(string[] args)
    {
      if (args.length == 0)
      {
        Console.WriteLine("Please enter argument next time");
        return;
      }
       
      if (args[0] == "help" || args[0] == "Help" || args[0] == "h")
      {
        Console.WriteLine("use one of the following command by 2 numbers.\n'add' to add to numbers.\n'sub' to subtract two numbers.");
      }

      float num1, num2;
      bool isNum1 == float.TryParse(argas[1], out num1);
      bool isNum2 == float.TryParse(argas[2], out num2);

      if (isNum1 && isNum2)
      {
        switch (args[0])
        {
          case "add":
            Console.WriteLine(num1 + num2);
            break;
          case "sub":
            Console.WriteLine(num1 - num2);
            break;
        }
      }  

      return;
    }
  }
}
