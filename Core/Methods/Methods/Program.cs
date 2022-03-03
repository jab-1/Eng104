using System;

namespace Methods;

public class Program
{
    public static void Main(string[] args)
    {
        ////Seeding with the current time in ticks
        //var rng = new Random();
        //var rngSeeded = new Random(42);
        //var between1And10 = rngSeeded.Next(1, 11);
        //Console.WriteLine(between1And10);

        //var rollDice1 = rng.Next(1, 7);
        //var rollDice2 = rng.Next(1, 7);
        //var rollDice3 = rng.Next(1, 7);

        //Console.WriteLine($"{rollDice1} {rollDice2} {rollDice3} {rollDice1 + rollDice2 + rollDice3}");
        //int y = 10;
        //int z = 10;
        //int[] arr = new int[] { 1, 2, 3 };
        //var result = DoThis(y, "Sad");
        //var result1 = DoThis(y);
        //var myPizza = OrderPizza(anchovies: true, pineapple: false);
        //Console.WriteLine(myPizza);
        //Add(y);
        //Console.WriteLine(y);
        //Add(ref z);
        //Console.WriteLine(z);
        //bool isLarge;
        //var result = DoThis(10, "Here's a string", out isLarge);
        //Console.WriteLine(isLarge);

        //var myTuple = ( fName: "Liam", lName: "Gallagher", age: 49 );
        ////Console.WriteLine(myTuple);
        ////Console.WriteLine(myTuple.lName);

        //(string fName, string lName, int age) myTuple2 = ("Noel", "Gallagher", 55);
        //var noel = myTuple2.fName;
        //var myTuple3 = ("Bon", noel);

        var result = ConvertPoundsToStones(98);
        Console.WriteLine(result);  
    }

    public static (int stones, int pounds) ConvertPoundsToStones(int pounds) 
    {
        const int poundsInAStone = 14;
        var st = pounds / poundsInAStone;
        var lb = pounds % poundsInAStone;
        var result = (st, lb);
        return result;
    }

    public static int DoThis(int x, string y, out bool z)
    {
        Console.WriteLine(y);
        z = (x > 9);
        return x * x;
    }

    public static void Add(int num)
    {
        num++;
    }

    public static void Add(ref int num)
    {
        num++;
    }

    public static string OrderPizza(bool anchovies, bool pineapple, bool mushroom = false)
    {
        var pizza = "Pizza with tomato sauce, cheese, ";
        if (anchovies) pizza += "anchovies, ";
        if (pineapple) pizza += "pineapple, ";
        if (mushroom) pizza += "mushroom, ";
        return pizza;

    }

    public static int DoThis(int x, string y  = "Happy")
    {
        Console.WriteLine($"I am feeling {y}");
        return x * x;
    }
}
