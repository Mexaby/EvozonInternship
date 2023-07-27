using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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

            Console.WriteLine("-----------------------------------------");
            //Assignemnt 2:
            //1
            PrintName();
            PrintSum();
            PrintFloat();
            PrintResults();

            //2
            Console.WriteLine("\nSum = " + Sum(3, 4));
            Console.WriteLine("Difference = " + Subtract(10, 4));
            Console.WriteLine("Product = " + Multiply(3, 4));
            Console.WriteLine("Quotient = " + Divide(10, 4));

            //3
            PrintLogo();

            //4
            Console.WriteLine("\nAverage = " + Average(4, 7, 9));

            //5
            Console.WriteLine("\nRest = " + Rest(8, 3));

            //6
            Console.WriteLine("\nTemperature (C) = " + ConvertFahrenheitToCelsius(99));

            //7
            Console.WriteLine("\nDistance (m) = " + ConvertInchesToMeters(46));

            //8
            CalculateAndPrintSpeed(256, 0, 1, 24);

            //9
            CalculateAreaAndPerimeterOfCircle(4);

            Console.ReadLine();
        }

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

        public static int Sum(int n, int m)
        {
            return n + m;
        }

        public static int Subtract(int n, int m)
        {
            return n - m;
        }

        public static float Multiply(int n, int m)
        {
            return n * m;
        }

        public static float Divide(int n, float m)
        {
            return n / m;
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

        public static float Average(int value1, int value2, float value3)
        {
            return (value1 + value2 + value3) / 3;
        }

        public static int Rest(int n, int m)
        {
            return n % m;
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
