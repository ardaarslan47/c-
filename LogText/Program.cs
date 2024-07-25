using System.Diagnostics;

namespace LogText;

public interface ILogger
{
    void Log(string message);
}

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        string root = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string path = Path.Combine(root, "Log");
        string file = Path.Combine(path, "log.txt");
        try
        {
            File.AppendAllText(file, message + "\n");
        }
        catch (DirectoryNotFoundException e)
        {
            Directory.CreateDirectory(path);
            File.AppendAllText(file, message + "\n");
        }
    }
}

public class DatabaseLogger : ILogger
{
    public void Log(string message)
    {
       Console.WriteLine("Logging to database"); 
    }
}

public class Application
{
    private readonly ILogger _logger;

    public Application(ILogger logger)
    {
        _logger = logger;
    }

    public void ManageLog(string message)
    {
        _logger.Log(message);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Application[] a = new Application[1]{new Application(new DatabaseLogger())};
        Application app = new Application(new FileLogger());
        Application dbapp = new Application(new DatabaseLogger());
        
        app.ManageLog("file logger");
        dbapp.ManageLog("database log");
    }
}