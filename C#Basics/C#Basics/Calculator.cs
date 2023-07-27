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

        public int Subtract(int n, int m)
        {
            return n - m;
        }

        public float Multiply(int n, int m)
        {
            return n * m;
        }

        public float Divide(int n, float m)
        {
            return n / m;
        }

        public float Average(int value1, int value2, float value3)
        {
            return (value1 + value2 + value3) / 3;
        }

        public int Rest(int n, int m)
        {
            return n % m;
        }

    }
}
