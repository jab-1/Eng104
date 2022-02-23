using System;

namespace CodeToTest;

public class Program
{
    static void Main(string[] args)
    {
        int timeOfDay = 21;
        var greeting = Greeting(timeOfDay);
        Console.WriteLine(greeting);

    }

    public static string Greeting(int timeOfDay)
    {
        return timeOfDay < 0 || timeOfDay > 24 ? throw new Exception("Invalid value")
            : timeOfDay >= 5 && timeOfDay <= 12 ? "Good morning!"
            : timeOfDay > 12 && timeOfDay <= 18 ? "Good afternoon!"
            : "Good evening!";
    }
}
