using System;

namespace Logger
{
  public delegate void LogDelegate(string massage);
  public class Logger 
  {
    public void LogtoFile(string massage)
    {
      Console.WriteLine("Log to file: {0}", massage);
    }
    public void LogtoDB(string massage)
    {
      Console.WriteLine("Log to DB: {0}", massage);
    }
  }
  internal class Program
  {
    public static void Main()
    {
      var logger = new Logger();
      LogDelegate logHandler = null; 
      logHandler += logger.LogtoFile;
      logHandler += logger.LogtoDB;
    
      // can use with try catch to check delegates in multicast delegate 
      foreach (LogDelegate handler in logHandler.GetInvocationList())
      {
        handler("delegate check");
      }

      InvokeSafely(logHandler, "Hello World");
    }

    static void InvokeSafely(LogDelegate logHandler, string massage)
    {
      LogDelegate tempLogHandler = logHandler;
      if (tempLogHandler != null)
      {
        tempLogHandler(massage);
      }
    }

    // checking if multicast delegate have specific delegate 
    static bool IsMethodInDelegate(LogDelegate logHandler, LogDelegate method)
    {
      if (logHandler == null) { return false; }
      foreach (var handler in logHandler.GetInvocationList())
      {
        if(handler == (Delegate)method)
        {
          return true;
        }
      }
      return false;
    }
  }
}
