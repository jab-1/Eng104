using System;

namespace Operators;

public class Program
{
    public static void Main(string[] args)
    {
        //int x = 5;
        //int y = 5;

        //int a = x++;
        //int b = ++y;

        //for (int i = 1; i <= 5; ++i)
        //{
        //    Console.WriteLine(i);
        //}

        //var c = 5 / 2; // 2
        //var d = 5.0 / 2; //2.5
        //var e = 5 / 3; //1

        //double f = 5 / 2;

        //Sebs burthday is 23 days from now. Put it in the format of days and weeks 

        //var daysInAWeek = 7;
        //var todalDaysToBirthday = 23;
        //var weeksToBirthday = todalDaysToBirthday / daysInAWeek;
        //var days = todalDaysToBirthday % daysInAWeek;
        //Console.WriteLine("Weeks: " + weeksToBirthday + " Days: " + days);

        //const int NUM_ROWS = 2;
        //const int NUM_COLS = 5;
        //bool running = true;
        //int row = 0;
        //int col = 0;
        //int spriteNo = -1;
        //while (running)
        //{
        //    spriteNo++;
        //    spriteNo %= NUM_ROWS * NUM_COLS;
        //    row = spriteNo / NUM_COLS;
        //    col = spriteNo % NUM_COLS;
        //}

        //int x = 5;
        //x += 5;
        ////x = x + 5;
        //x %= 5;
        ////x = x % 5
        ///
        //int j = 5, k = 3, m = 4;
        //m += +j++ + ++k;

        //what will the values of m, j and k be


    }

    public static bool EvenOdd(int num)
    {
        //Will reture true if num is even, false if it is odd
        return num % 2 == 0;
    }

    public static int FinSumDiv3And5(int n)
    {
        //it will add up all numbers between 1 and n inclusive
        //If divisisble by 3 or 5
        //And return this sum
        //return Enumerable.Range(1, n + 1).Where(c => c % 5 == 0 || c % 3 == 0).Sum();

        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += sum;
            }
        }
        return sum;
    }
}
