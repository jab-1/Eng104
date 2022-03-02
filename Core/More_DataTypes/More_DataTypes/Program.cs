using System;
using System.Diagnostics;
using System.Text;

namespace More_DataTypes;

public enum Suit
{
    HEARTS, CLUBS, DIAMONDS, SPADES
}

public enum Size
{
    SMALL = 10, MEDIUM = 25, LARGE =50
}

public class Trainee
{
    private readonly string _name;
    public Trainee(string name)
    {
        _name = name;
    }

}
public class Program
{
    public static void Main (string[] args)
    {
        //var trainee = new Trainee("Nish");

        ////STRINGS

        //string steven = "Steven Maddox";
        //steven = "Steven Mandal";

        //String nish = "Nish Kumar";
        //String nish2 = new String("Nish Kumar");
        //string nish3 = "Nish Kumar";

        //if (nish.Equals(nish2))
        //{
        //    Console.WriteLine("nish and nish2 are equal");
        //}
        //if (nish == nish3)
        //{
        //    Console.WriteLine("nish and nish3 are equal");
        //}

        //string names = "Jab,James,Gaurav,Goncalo";

        //string[] namesToArray = names.Split(',');

        //foreach (var name in namesToArray)
        //{
        //    Console.WriteLine(name);
        //}

        //var myString = " C# list fundamentals ";
        //Console.WriteLine(StringExercise(myString));
        //Console.WriteLine(StringBuilderExercise(myString));

        //var spartaString = String.Concat("This", " is ", "Sparta");
        //Console.WriteLine(spartaString);
        //StringInterpolation("Nish");

        //var num1 = 2;
        //var num2 = 3;
        //var fString = $"{num1} to the power of {num2} is {Math.Pow(num1,num2)}";
        //Console.WriteLine(fString);

        //var fString2 = $"That will be {num1/3.0:C2},  please";
        //var fString3 = $"You received {1 / 10.0:P2}  in your test";
        //Console.WriteLine(fString3);
        //ParsingStrings();

        //OneDArray();
        //MultiDArrays();
        //char[,] gridTwo =
        //{
        //    { 'a','b' },
        //    {'c' ,'d'},
        //    {'e' ,'f'},
        //    {'g' ,'h'}
        //};
        //foreach (char c in gridTwo)
        //{
        //    Console.WriteLine(c);
        //}
        //JaggedArrays();

        //string[] trainingGroup = { "Laura", "Steven", "James", "Jab", "Ned" };
        //string[][] spartaAcademy = new string[][]
        //{
        //    new string[]{ "Marian", "Goncalo", "Seb", "Stanni", "David", "Gaurav" },
        //    trainingGroup
        //};
        //foreach (string[] arr in spartaAcademy)
        //{
        //    foreach (var item in arr)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //DateTimeMethods();

        //var birthDay = new DateTime(1989,11, 2);
        //Console.WriteLine(birthDay);
        //Console.WriteLine(birthDay.ToString("y-M-d"));
        //Console.WriteLine(birthDay.ToString("dd/MM/yy"));
        //Console.WriteLine(birthDay.ToString("ddd.MMM.yyy"));
        //Console.WriteLine(birthDay.ToString("MMMM.yyyy ddd"));

        //TimeSpan myAge = DateTime.Now - birthDay;
        ////Console.WriteLine(myAge);
        //var myAgeInYears = myAge.Days / 365.25;
        //Console.WriteLine($"Nish is {myAgeInYears:N1} years old to one decimal point");
        //Console.WriteLine($"Nish is {myAgeInYears:N0} years old");

        ////DateOnly
        //var myDate = new DateOnly(1989, 11, 2);
        //Console.WriteLine(myDate);
        //var today = DateTime.Now;
        //DateOnly today1 = DateOnly.FromDateTime(today);
        //Console.WriteLine(today);
        //Console.WriteLine(today1);

        ////Stop watch
        //var stopwatch = new Stopwatch();
        //stopwatch.Start();
        //long total = 0;
        //for (int i = 0; i < 1000; i++)
        //{
        //    total += i;
        //}
        //stopwatch.Stop();
        //Console.WriteLine(stopwatch.Elapsed);
        //Console.WriteLine(stopwatch.ElapsedMilliseconds);
        //Console.WriteLine(stopwatch.ElapsedTicks);
        // Enum();

        //var mediumValue = (int)Size.MEDIUM;
        //var mySize = (Size)50;

        //var anotherSuit = Enum.Parse(typeof(Suit), "CLUBS");

        //const int dozen = 12;
        //dozen = 13;
    }

    public static void Enums()
    {
        Suit theSuit = Suit.HEARTS;
        //if (theSuit == suits.SPADES)
        //{
        //    Console.WriteLine($"Suit is {suits.SPADES}");
        //}
        //else
        //{
        //    Console.WriteLine($"Suit is {theSuit} not {suits.SPADES}");

        //}

        switch (theSuit)
        {
            case Suit.HEARTS:
                Console.WriteLine("Thank You");
                break;
            default:
                Console.WriteLine("Goodbye");
                break;
  
        }
    }
    public static void DateTimeMethods()
    {
        var now = DateTime.Now;
        Console.WriteLine($"The time now is {now}\n");
        //Console.WriteLine($"In ticks this is {now.Ticks}");
        //Console.WriteLine(DateTime.MinValue);
        //Console.WriteLine(DateTime.MaxValue);
        var tomorrow = now.AddDays(1);
        Console.WriteLine(tomorrow);
    }

    public static void JaggedArrays()
    {
        int[][] intJArray = new int[2][];
        intJArray[0] = new int[4];
        intJArray[1] = new int[2];
        intJArray[0][2] = 3;
        intJArray[1][0] = 5;
    }
    public static void MultiDArrays()
    {
        int[,] grid = new int[2, 4];
        grid[0,1] = 6;
        grid[1,0] = 8;
        grid[1,3] = 10;
    }
    public static void OneDArray()
    {
       
        int[] myIntArray = { 12, 34, 23, 45, 56 };
        //Array.Reverse(myIntArray);
        //Array.ForEach(myIntArray, x => Console.WriteLine(x));

        //myIntArray.OrderBy(x => x);
        //myIntArray.OrderByDescending(x => x);
        //var traineesArray = new string[]{ "David", "Marian", "Stanni" };
        //var traineesArray2 = new string[3];
        //traineesArray[0] = "Jab";
        //traineesArray[1] = "James";
        //traineesArray[2] = "Laura";

        //traineesArray2[0] = "Jab";
        //traineesArray2[1] = "James";
        //traineesArray2[2] = "Laura";
        ////traineesArray2[3] = "Taylor Swift";
    }



    public static void ParsingStrings()
    {
        ///PARSE
        //Console.WriteLine("How many apples?");
        //string input = Console.ReadLine();
        //int numApples = Int32.Parse(input);
        //Console.WriteLine($"{numApples} apples");

        ////Try parse
        bool isSuccess;
        ConsoleKeyInfo cki;
        do
        {
            Console.WriteLine("How many apples?");
            string input = Console.ReadLine();

            double numApples;
            isSuccess = Double.TryParse(input, out numApples);

            Console.WriteLine($"{numApples} apples");
            if (!isSuccess)
            {
                Console.WriteLine("Please enter a valid number");
            }
            Console.WriteLine($"Continue or leave? Press Esc to leave.");
            cki = Console.ReadKey();
        } while (cki.Key != ConsoleKey.Escape);
        Console.WriteLine("You did not enter a valid number");
    }
    public static void StringInterpolation(string str)
    {
        Console.WriteLine("My name is : " + str + " using +");
        Console.WriteLine($"My name is {str} using interpolation");
    }

    private static string StringBuilderExercise(string myString)
    {
        var trimmpedUpperString = myString.Trim().ToUpper();
        var nPos = trimmpedUpperString.IndexOf('N');
        StringBuilder sb = new StringBuilder (trimmpedUpperString);
        sb.Replace('L', '*').Replace('T', '*');
        sb.Remove(nPos + 1, sb.Length - nPos - 1);
        sb.Append(" and is better than C++ and Java");
        return sb.ToString();
    }

    private static string StringExercise(string myString)
    {
        var trimmedString = myString.Trim();
        var ucString = trimmedString.ToUpper();
        var replacedString = ucString.Replace('L', '*');
        //C# *IS* FUNDAMENT*A*S
        var replacedString2 = replacedString.Replace('T', '*');
        var nPos = replacedString2.IndexOf('N');
        var finalString = replacedString2.Remove(nPos + 1);
        return finalString;
    }
}
