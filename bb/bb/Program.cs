using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputArray = input.ToCharArray();
            bool isSorted = false;

            while (!isSorted)
            {
                isSorted = true;

                for (int i = 0; i < inputArray.Length - 1; i++)
                {
                    if (inputArray[i] > inputArray[i + 1])
                    {
                        char temp = inputArray[i];
                        inputArray[i] = inputArray[i + 1];
                        inputArray[i + 1] = temp;
                        isSorted = false;
                    }
                }
            }
            
            string sortedInput = new string(inputArray);
            Console.WriteLine(sortedInput);
            Console.ReadLine();
        }
    }
}
