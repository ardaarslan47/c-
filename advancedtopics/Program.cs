using System.Data.SqlTypes;
using System.Net.Security;

namespace advancedtopics;

public class LowerThanZeroExeption : Exception
{
    public LowerThanZeroExeption()
    {
    }

    public LowerThanZeroExeption(string message)
        : base(message)
    {
    }

    public LowerThanZeroExeption(string message, Exception inner)
        : base(message, inner)
    {
    }
}
enum Day 
{
    Pzt, Sl, Cr, Pr, Cm, Cmt, Pz
}
struct Game
{
    public string name;
    public string dev;
}
class Program
{
    /// <summary>
    /// Takes nullable object and return nonnullable version
    /// </summary>
    /// <param name="nullable">Nullable object, doesnt accept nonnulable parameter.</param>
    /// <typeparam name="T">Any object</typeparam>
    /// <returns>Nonnullable object</returns>
    /// <exception cref="ArgumentNullException">If parameter is null</exception>
    private static T ConvertNullable<T>(T? nullable) where T: struct 
    {
        T result;
        try
        {
            result = (T)nullable;
        }
        catch (InvalidOperationException e)
        {
            throw new ArgumentNullException();
        }

        return result;
    }
    private static void DisplayTime(DateTime time)
    {
        Console.WriteLine("{0}'o clock {1} minutes and {2} seconds.", time.Hour, time.Minute, time.Second);
    }
    static void Main(string[] args)
    {
        // interfaces
        Game game;
        game.name = "pokemon";
        game.dev = "capcom";
        
        Console.WriteLine(game.name + game.dev);
        Console.WriteLine(Day.Pzt);

        // random
        Random rand = new Random();
        string[] choices = { "yes", "no", "maybe" };

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(choices[rand.Next(0,3)]);
        }

        // custom execption
        try
        {
            int val = int.Parse("-10");
            if (val < 0)
            {
                throw new LowerThanZeroExeption("AAA");
            }
        }
        catch (LowerThanZeroExeption e)
        {
            Console.WriteLine(e);
        }

        // datetime and timespan
        DateTime now = DateTime.Now;
        // DateTime birthday = DateTime.Parse(Console.ReadLine());

        DisplayTime(now);
        // TimeSpan days = now.Subtract(birthday);
        
        // Console.WriteLine(days.Days);
        
        // nullables
        int? num1 = null;
        int? num2 = 1337;

        double? d1 = new double?();
        
        Console.WriteLine("{0} {1} {2}", num1, num2, d1);
        
        if (num1 is null) Console.WriteLine("null");

        double? num3 = null;
        double? num4 = 123.23;
        double num5 = 1;

        try
        {
            num5 = ConvertNullable(num3);
        }
        catch (ArgumentNullException e)
        {
            num5 = 0.0;
        }
        
        Console.WriteLine(num5);
        
    }
}