using ExceptionsApp;
using System;

namespace ExpceptionsApp;

public class Program
{
    public static void Main(string[] args)
    {
        //string text;
        //string fileName = "";

        //try 
        //{ 
        //    text = File.ReadAllText(fileName);
        //    Console.WriteLine(text);
        //}
        //catch (FileNotFoundException ex)
        //{
        //    Console.WriteLine("Sorry I can't find: " + fileName);
        //}
        //catch (ArgumentException ex)
        //{
        //    Console.WriteLine("You gave me an empty file name");
        //}
        //finally
        //{
        //    Console.WriteLine("I'm always run whatever happens");
        //}

        try
        {
            Console.WriteLine("Stanni's mark is 82: " + Grade(82));
            Console.WriteLine("Nish's mark is -23: " + Grade(-23));
        }
        catch (GradeException ex)
        {

            Console.WriteLine("Invalid data, please try again");
            Console.WriteLine(ex.Message);
        }

    }

    public static string Grade(int mark)
    {
        if (mark < 0 || mark > 100)
        {
            throw new GradeException("Mark: " + mark + " " + "Allowed range 0-100");
        }
        return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
    }
}
