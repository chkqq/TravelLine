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
            bool hasSwapped;
            do
            {
                hasSwapped = false;
                for (int i = 0; i < Arr.Length - 1; i++)
                {
                    if (Arr[i] > Arr[i + 1])
                    {
                        char temp = Arr[i];
                        Arr[i] = Arr[i + 1];
                        Arr[i + 1] = temp;
                        hasSwapped = true;
                    }
                }
            } while (hasSwapped);
            
            return Arr;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputArray = input.ToCharArray();
            char[] outputArray = BubbleSort(inputArray);
            Console.WriteLine(new string(outputArray));
            Console.ReadLine();
        }
    }
}
