using System;

namespace intro
{
  // you can create delegate here
  class Program
  {
    // delegates provide a way to pass a method as parameter
    // declaration:
    public delegate void Notify(string message);

    // invocation:
    internal static void Main(string[] args)
    {
        // instantiation:
        Notify notifyConsoleDelegate = ShowMessage;

        SendNotification("Hello World", notifyConsoleDelegate);
        SendNotification("Hello World", ShowMessage);

        ShowMessage("Hello World");
        notifyConsoleDelegate("Hello World");

        SendNotification("Hello World", LogToFile);
    }

    // every method matches return type and parameters can use in delegate parameter
    public static void ShowMessage(string message)
    {
      Console.WriteLine(message);
    }

    public static void LogToFile(string message)
    {
      Console.WriteLine($"Log to file: {message}");
    }

    // function takes argument method
    public static void SendNotification(string message, Notify notify)
    {
      notify(message);
    }
  }
}
