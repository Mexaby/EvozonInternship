using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics
{
    internal class PrLists
    {
        //Arrays assignment 3
        //1
        public void PrintList(List<int> list)
        {
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }

        //2
        public void AddToEndOfList(List<int> list, int number)
        {
            list.Add(number);
        }

        //3
        public void PrintListFromValue(List<int> list, int number)
        {
            int i = 0;
            foreach (var element in list)
            {
                if (i >= number)
                {
                    Console.WriteLine(element);
                }
                i++;
            }
        }

        //4
        public void PrintReverse(List<int> list)
        {
            for(int i = list.Count - 1; i >=0; i--)
            {
                Console.WriteLine(list[i]);
            }
        }

        //5

    }


}
