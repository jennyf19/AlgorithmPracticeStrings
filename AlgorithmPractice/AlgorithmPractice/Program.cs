using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 4, 5, 6, 2, 3, 1, 9, 10 };
            Console.WriteLine("enter a positive integer: ");
            int target = Int32.Parse(Console.ReadLine());
            ReturnIndices(myArray, target);
            Console.ReadLine();
        }
        public static void ReturnIndices(int[] myArray, int target)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length; j++)
                {
                    if (myArray[i] + myArray[j] == target)
                    {
                        Console.WriteLine("The numbers that sum to " + target + " are at indices {0} and {1}", i, j);
                    }
                }

            }
            Console.WriteLine("There are no possible numbers in the array");
            return;
        }
    }
}
