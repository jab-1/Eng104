using System;

namespace ControlFlowApp;

public class Program
{
    public static void Main(string[] args)
    {
        //int mark = 82;
        ////var grade = mark >= 65 ? "Pass" : "Fail";

        //var grade = GetGrade(mark);

        //var message = Priority(7);

        //Console.WriteLine(DrivingLaw(22));

        var nums = new List<int> {  };
        Console.WriteLine("Highest foreach: " + LoopTypes.HighestForEachLoop(nums));
        Console.WriteLine("Highest for loop: " + LoopTypes.HighestForLoop(nums));
        Console.WriteLine("Highest while loop: " + LoopTypes.HighestWhileLoop(nums));
        Console.WriteLine("Highest do-while loop: " + LoopTypes.HighestDoWhileLoop(nums));
    }
    public static string DrivingLaw(int age)
    {
        string law = "";
        switch (age)
        {
            case < 18:
                law = "Cannot legally drive";
                break;
             case < 23:
                law = "Can legally drive, but cannot hire a car";
                break;
            default:
                law = "Can legally drive and rent a car";
                break;
        }
        return law;
    }
    public static string Priority(int level)
    {

        string priority = "Code ";
        switch (level)
        {
            case 3:
                priority += "Red";
                break;
            case 2:
            case 1:
                priority += "Amber";
                break;
            case 0:
                priority += "Green";
                break;
            default:
                priority = "Error";
                break;
        }

        return priority;
    }

    private static string GetGrade(int mark)
    {
        return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
    }
}
