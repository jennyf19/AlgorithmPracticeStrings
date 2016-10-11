using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsRemoveDup
{
    class Program
    {
        static void Main(string[] args)
        {
            //[] myArray = { 3, 3, 4, 4, 5};
            string input = "hello world";
            char[] inputArray = input.ToCharArray();
            Array.Reverse(inputArray);
            string output = new string(inputArray);
            Console.WriteLine(output);
            //RemoveRepeat(myArray, 4);
            //RemoveDup(myArray);
            Console.ReadLine();
        }
        #region remove duplicate 
        /*public static int RemoveDup(int[] myArray)
        {
            if (myArray.Length == 0)
            {
                return 0;
            }
            int i = 0;
            for (int j = 1; j < myArray.Length; j++)
            {
                if (myArray[j] != myArray[i])
                {
                    i++;
                    myArray[i] = myArray[j];
                }
            }
            return i + 1;
        }   */
        #endregion

        #region RemoveRepeat
        /*public static int RemoveRepeat(int[] array, int value)
        {
            int i = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if(array[j] != value)
                {
                    array[i] = array[j];
                    i++;
                }
            }
            return i;
        }         */
        #endregion
        public char[] ReverseString(char[] inputArray)
        {
            Array.Reverse(inputArray);
            string output = new string(inputArray);
            Console.WriteLine(inputArray);
            return inputArray;
        }
    }
}
