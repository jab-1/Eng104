using System;
using System.Text;

namespace More_DataTypes;

public class Program
{
    public static void Main (string[] args)
    {
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
        char[,] gridTwo =
        {
            { 'a','b' },
            {'c' ,'d'},
            {'e' ,'f'},
            {'g' ,'h'}
        };
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
