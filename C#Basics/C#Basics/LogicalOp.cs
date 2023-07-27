using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_Basics
{
    internal class LogicalOp
    {
        //3
        public int CheckBiggerNumber(int value1, int value2)
        {
            if (value1 < value2)
            {
                return value2;
            }
            else
            {
                return value1;
            }
        }

        //4
        public string CheckText(string text)
        {
            if (text.Equals("FastTrackIT"))
            {
                return "Learning text comparison";
            }
            else
            {
                return "Got to try some more";
            }
        }

        //5
        public string CheckTestAndNumber(string text, int number)
        {
            if (text.Equals("FastTrackIT") && number <= 3)
            {
                return text + " " + number;
            }
            else if (text.Equals("FastTrackIT") && number >= 4)
            {
                return number + " " + text;
            }
            else
            {
                return "Conditions not met!";
            }

        }

        //6
        public string SnowAmount(int amount)
        {
            if (amount > 8 || amount == 6)
            {
                return "The amount of snow this winter was(cm): " + amount;
            }
            else
            {
                return "The forecast snow is(cm): " + amount;
            }
        }

        //7
        public string CheckNumber(int number)
        {
            if (number > 3 && number != 4)
            {
                return "The number is greater than 3 and not equal to 4";
            }
            else if (number == 4)
            {
                return "The number is equal to 4";
            }
            else
            {
                return "The number is lower than 3";
            }
        }

        //8
        public void PrintNumber(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("The number is: 1 !");
                    break;
                case 2:
                    Console.WriteLine("The number is: 2 !");
                    break;
                case 3:
                    Console.WriteLine("The number is: 3 !");
                    break;
                case 4:
                    Console.WriteLine("The number is: 4 !");
                    break;
                default:
                    Console.WriteLine("Invalid number!");
                    break;
            }
        }

        //9
        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        //10
        public bool IsEligibleToVote(int age)
        {
            return age >= 18;
        }

        //11
        public int PrintLargestNumber(int number1, int number2, int number3)
        {
            return max(max(number1, number2), number3);
        }

        public int max(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            return number2;
        }

        //Arrays Assignemnt 1
        public void PrintArrayProgress()
        {
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
                Console.Write(array[i] + " ");
                Thread.Sleep(25);
            }
        }

        //3
        public int[] EvenArray(int[] array)
        {
            int j = 0;
            for (int i = 0; i <= 100; i += 2)
            {
                array[j] = i;
                j++;
            }

            return array;
        }

        //4
        public double ArrayAverage(int[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum / array.Length;
        }

        //5
        public Boolean IsStringInArray(string[] stringArray, string word)
        {
            foreach (string s in stringArray)
            {
                if (s.Equals(word))
                {
                    return true;
                    break;
                }
            }
            return false;
        }

        //6
        public int IsNumberInArray(int[] array, int number)
        {
            int pos = 0;
            foreach (int i in array)
            {
                if (number == i)
                {
                    return pos;
                }
                pos++;
            }

            return -1;
        }

        //7
        public void PrintPattern()
        {
            //char[] array = new char[20];
            //for(int i = 0; i <  array.Length; i+=2)
            //{
            //    array[i] = '-';
            //    array[i + 1] = ' ';
            //}
            //array[20] = '\n'

            //for(int i = 0; i < 10; i++)
            //{
            //    for(int j = 0; j < array.Length; j++)
            //    {

            //    }
            //}

            string[] array = new string[10];
            string dashes = "- - - - - - - - - -";

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = dashes;
                Console.WriteLine(array[i] + "\n");
            }
        }

        //8
        public int[] DeleteElementFromArray(int[] array, int number)
        {
            int numIdx = Array.IndexOf(array, number);
            List<int> tmp = new List<int>(array);
            tmp.RemoveAt(numIdx);

            return tmp.ToArray();
        }

        //9
        public int ReturnSecondSmallestElement(int[] array)
        {
            Array.Sort(array);
            int[] distinct = array.Distinct().ToArray();
            return distinct[1];
        }

        //10
        public void CopyArray(int[] arrayToCopy, int[] arrayToCopyInto)
        {
            arrayToCopy.CopyTo(arrayToCopyInto, 0);

        }
    }
}