using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics
{
    public class Calculator
    {
        public int Sum(int n, int m)
        {
            return n + m;
        }

        //overloaded methods
        public float Sum(float n, float m)
        {
            return n + m;
        }

        public double Sum(double n, double m)
        {
            return n + m;
        }
        //-----------------------------------------------
        public int Subtract(int n, int m)
        {
            return n - m;
        }
        
        //overloaded methods
        public float Subtract(float n, float m)
        {
            return n - m;
        }

        public double Subtract(double n, double m)
        {
            return n - m;
        }
        //-----------------------------------------------
        public int Multiply(int n, int m)
        {
            return n * m;
        }

        //overloaded methods
        public float Multiply(float n, float m)
        {
            return n * m;
        }

        public double Multiply(double n, double m)
        {
            return n * m;
        }
        //-----------------------------------------------
        public float Divide(int n, float m)
        {
            return n / m;
        }
        
        //overloaded methods;
        public int Divide(int n, int m)
        {
            return n / m;
        }

        public double Divide(double n , double m)
        {
            return n / m;
        }
        //-----------------------------------------------
        public int Average(int value1, int value2, int value3)
        {
            return (value1 + value2 + value3) / 3;
        }
        //overloaded methods
        public float Average(float value1, float value2, float value3)
        {
            return (value1 + value2 + value3) / 3;
        }

        public double Average(double value1, double value2, double value3)
        {
            return (value1 + value2 + value3) / 3;
        }
        //-----------------------------------------------
        public int Rest(int n, int m)
        {
            return n % m;
        }

    }
}
