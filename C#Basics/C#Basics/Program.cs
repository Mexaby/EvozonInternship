using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignemnt 1:
            //1
            Console.WriteLine("Hello");
            Console.WriteLine("Csabi");
            Console.WriteLine();

            //2
            Console.WriteLine(3 + 2);
            Console.WriteLine();

            //3
            Console.WriteLine((float)5 / 3);
            Console.WriteLine();

            //4
            Console.WriteLine(-5 + 8 * 6);
            Console.WriteLine((55 + 9) % 9);
            Console.WriteLine(20 + -3 * 5 / 8);
            Console.WriteLine(+15 / 3 * 2 - 8 % 3);
            Console.WriteLine();

            Console.WriteLine("\n-----------------------------------------");
            //Assignemnt 2:
            //1
            PrintName();
            PrintSum();
            PrintFloat();
            PrintResults();

            //2
            Calculator calculator = new Calculator();

            Console.WriteLine("\nSum = " + calculator.Sum(3, 4));
            Console.WriteLine("Difference = " + calculator.Subtract(10, 4));
            Console.WriteLine("Product = " + calculator.Multiply(3, 4));
            Console.WriteLine("Quotient = " + calculator.Divide(10, 4));

            //3
            PrintLogo();

            //4
            Console.WriteLine("\nAverage = " + calculator.Average(4, 7, 9));

            //5
            Console.WriteLine("\nRest = " + calculator.Rest(8, 3));

            //6
            Console.WriteLine("\nTemperature (C) = " + ConvertFahrenheitToCelsius(99));

            //7
            Console.WriteLine("\nDistance (m) = " + ConvertInchesToMeters(46));

            //8
            CalculateAndPrintSpeed(256, 0, 1, 24);

            //9
            CalculateAreaAndPerimeterOfCircle(4);


            //Assignment 3
            Console.WriteLine("\n------------------------------------");
            LogicalOp logicalOp = new LogicalOp();

            //3
            Console.WriteLine("The larger number is " + logicalOp.CheckBiggerNumber(4, 1));

            //4
            Console.WriteLine(logicalOp.CheckText("This will not be  equal"));

            //5
            Console.WriteLine(logicalOp.CheckTestAndNumber("FastTrackIT", 2));

            //6
            Console.WriteLine(logicalOp.SnowAmount(6));

            //7
            Console.WriteLine(logicalOp.CheckNumber(4));

            //8
            logicalOp.PrintNumber(3);

            //9
            Console.WriteLine(logicalOp.IsNumberEven(4));

            //10
            Console.WriteLine(logicalOp.IsEligibleToVote(34));

            //11
            Console.WriteLine(logicalOp.PrintLargestNumber(3, 5, 7));


            //Arrays Assignment 1
            //1
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine(calculator.Sum(4.5, 4));
            Console.WriteLine(calculator.Subtract(4.5, 7));
            Console.WriteLine(calculator.Divide(4.5, 8));
            Console.WriteLine(calculator.Multiply(4.5, 2));
            Console.WriteLine(calculator.Average(4.5, 2, 2.3));

            //2
            logicalOp.PrintArrayProgress();

            //3
            int[] array = new int[51];
            Console.WriteLine();
            foreach (int element in logicalOp.EvenArray(array))
            {
                Console.Write(element + " ");
                Thread.Sleep(25);
            }

            //4
            int[] averageArray = { 12, 10, 24 };
            Console.WriteLine("\n\n" + logicalOp.ArrayAverage(averageArray));

            //5
            string[] stringArray = { "apple", "banana", "horse", "shoe", "monitor" };
            Console.WriteLine("\n" + logicalOp.IsStringInArray(stringArray, "horse"));

            //6
            int[] numberArray = { 1, 3, 2, 4, 5, 6, 7, 1, 2 };
            Console.WriteLine("\n" + logicalOp.IsNumberInArray(numberArray, 4));

            //7
            Console.WriteLine();
            logicalOp.PrintPattern();

            //8
            Console.WriteLine();
            int[] newArray = logicalOp.DeleteElementFromArray(numberArray, 4);
            foreach (int element in newArray)
            {
                Console.Write(element + " ");
            }

            //9
            Console.WriteLine("\n" + logicalOp.ReturnSecondSmallestElement(numberArray));

            //10
            Console.WriteLine();
            int[] emptyArray = new int[numberArray.Length];
            logicalOp.CopyArray(numberArray, emptyArray);
            foreach (int element in emptyArray)
            {
                Console.Write(element + " ");
            }

            //Arrays assignment 3
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine();
            PrLists prLists = new PrLists();

            //1
            List<int> integerList = new List<int> { 1, 2, 3, 4, 5, 6, 7};
            prLists.PrintList(integerList);

            //2
            Console.WriteLine();
            prLists.AddToEndOfList(integerList, 8);
            prLists.PrintList(integerList);

            //3
            Console.WriteLine();
            prLists.PrintListFromValue(integerList, 3);

            //4
            Console.WriteLine();
            prLists.PrintReverse(integerList);

            //5


            Console.ReadKey();
        }
        //----------------------------------------------------------------
        //----------------------------------------------------------------
        //----------------------------------------------------------------
        public static void PrintName()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Csabi");
            Console.WriteLine();
        }

        public static void PrintSum()
        {
            Console.WriteLine(3 + 2);
            Console.WriteLine();
        }

        public static void PrintFloat()
        {
            Console.WriteLine((float)5 / 3);
            Console.WriteLine();
        }

        public static void PrintResults()
        {
            Console.WriteLine(-5 + 8 * 6);
            Console.WriteLine((55 + 9) % 9);
            Console.WriteLine(20 + -3 * 5 / 8);
            Console.WriteLine(+15 / 3 * 2 - 8 % 3);
        }

        public static void PrintLogo()
        {
            Console.WriteLine("\n  CCCC           /        /");
            Console.WriteLine("C           ----/--------/----");
            Console.WriteLine("C              /        /");
            Console.WriteLine("C             /        /");
            Console.WriteLine("C        ----/--------/----");
            Console.WriteLine("  CCCC      /        /");
        }



        public static double ConvertFahrenheitToCelsius(double temp)
        {
            return 5.0 / 9.0 * (temp - 32);
        }

        public static double ConvertInchesToMeters(double inches)
        {
            return inches * 0.0254;
        }

        public static void CalculateAndPrintSpeed(double distanceInMeters, int hours, int minutes, int seconds)
        {
            // Convert time to seconds
            double totalTimeInSeconds = (hours * 3600) + (minutes * 60) + seconds;

            // Convert distance to meters
            double distanceInMiles = distanceInMeters / 1609.0;
            double distanceInKilometers = distanceInMeters / 1000.0;

            // Print the results
            Console.WriteLine("\nSpeed:");
            Console.WriteLine("m/s: " + distanceInMeters / totalTimeInSeconds);
            Console.WriteLine("km/s: " + distanceInKilometers / (totalTimeInSeconds / 3600));
            Console.WriteLine("mi/h: " + distanceInMiles / (totalTimeInSeconds / 3600));
        }

        public static void CalculateAreaAndPerimeterOfCircle(double radius)
        {
            Console.WriteLine("\nPerimeter = " + 2 * Math.PI * radius);
            Console.WriteLine("Area = " + Math.PI * Math.Pow(radius, 2));
        }
    }

}
