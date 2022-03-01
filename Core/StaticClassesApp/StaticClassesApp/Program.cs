using System;

namespace StaticClassesApp;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Trainee.GetNumberOfTrainees());
        var nishMan = new Trainee(30)
        {
            Course = "C# Dev",
            Name = "Nish Mandal",
        };

        var nishKumar = new Trainee(35)
        {
            Course = "Java Dev",
            Name = "Nish Kumar",
        };

        Console.WriteLine(nishMan.Name + " " + nishMan.Age + " " + nishMan.Course);
        Console.WriteLine(nishKumar.Name + " " + nishKumar.Age + " " + nishKumar.Course);
        Console.WriteLine(nishMan.SayHello());
        Console.WriteLine(Trainee.GetNumberOfTrainees());

    }
}


public class Trainee
{
    public string Course { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    private static int _noOfTrainees = 0;

    public Trainee(int age)
    {
        Age = age;
        _noOfTrainees++;
    }

    public static int GetNumberOfTrainees()
    {
        return _noOfTrainees;
    }

    public string SayHello()
    {
        return "Hello " + Name;
    }
}


public static class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}