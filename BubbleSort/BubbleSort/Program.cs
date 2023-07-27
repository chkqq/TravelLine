using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        public static char[] BubbleSort(char[] Arr)
        {
            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;

                for (int i = 0; i < Arr.Length - 1; i++)
                {
                    if (Arr[i] > Arr[i + 1])
                    {
                        char temp = Arr[i];
                        Arr[i] = Arr[i + 1];
                        Arr[i + 1] = temp;
                        isSorted = false;
                    }
                }
            }
            return Arr;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputArray = input.ToCharArray();
            inputArray = BubbleSort(inputArray);
            Console.WriteLine(inputArray);
            Console.ReadLine();
        }
    }
}
