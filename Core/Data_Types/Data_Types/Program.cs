using System;
using System.Collections.Generic;
namespace Data_Types;

public class Program
{
    public static void Main(string[] args)
    {
        ///Why C# is decribed as a strongly typed langauge
        ///Statically typed, type safe and memory

        ///Var key word
        //var x = new Person();

        //var name = "Stanni";
        //var isClean = true;
        //var letter = 'M';
        //var uLongNum = 52uL;

        ////Integral types
        //var list= new List<decimal>();
        //byte b = 8; //8 bits
        //short s = 16;//int16
        //int i = 32; //int32
        //long l = 64; //int64

        //var n1 = -65;
        //var n2 = 64;
        //var n3 = -100_000;
        //var n4 = 100_000;
        //var n5 = 4_000_000_000;
        //var n6 = -5_000_000_000;
        //var n7 = 5_000_000_000;

        ////Floating types
        //decimal sum = 0;
        //for (int i = 0; i < 100_000; i++)
        //{
        //    sum += 2 / 5.0m;
        //}

        //Console.WriteLine("2/5 added 100,000 times: " + sum);
        //Console.WriteLine("2/5 multiplied by 100,000: " + (2 / 5.0f * 100_000));

        ////Safe type coversion

        //var result = 5.50/ 5;

        ////Implicit casting
        //var myInt = 5;
        //double myNum = myInt;


        ////Explciit casting
        //double myNum2 = 2.0;
        //int myInt2 = (int)myNum2;

        ////Overflow and underflow

        //byte num = 255;
        //num++;

        //byte num1 = 0;
        //num1--;

        //sbyte sNum = SByte.MaxValue;
        //sNum++;


        //byte c = 255;
        //sbyte d = (sbyte)c;
        //string cBinary = Convert.ToString(c, 2);
        //string dBinary = Convert.ToString(d, 2);

        ////Casting
        ///
        //double x = 3.14159265359;
        //float y = (float)x;

        //int numCows = 260;
        //uint countCows = (uint)numCows;
        //byte byteCows = (byte)numCows;

        ///Incomptabile types
        //float pi = 3.14f;
        //bool boolPi = (bool)pi;

        //// Convert class
        //var theInt = 5;
        ////No conversion
        //var anotherInt = Convert.ToInt32(theInt);
        //// safe - widening
        //var myDouble = Convert.ToDouble(theInt);
        ////Narrowing (unsafe)
        //var myShort = Convert.ToInt16(theInt);
        ////InvalidCastException
        //var pi = 3.142;
        //DateTime piDay = Convert.ToDateTime(pi);

        //var five = "five";
        //var fiveAsInt = Int32.Parse(five);

        ////Dealing with int over and underflow
        ///

            byte num = Byte.MaxValue;
            Console.WriteLine("Byte max: " + num);
            num++;
            Console.WriteLine(num);

        

    }
}

public class Person { }