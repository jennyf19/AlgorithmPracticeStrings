using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 2, 1 };
            LinkedListNode<string> list = new LinkedListNode<string>("1, 2, 3, 2, 1");
            IsPalindrome(list);
            Console.ReadLine();
        }

        public static bool IsPalindrome(LinkedListNode<string> list)
        {
            if(list == null)
            {
                return false;
            }

            string current = list.Value;
            string runner = list.Value.
                                                          
            Stack<string> myStack = new Stack<string>();

            while (runner != null && list.Next.Next.Value != null)
            {
                myStack.Push(list.Value);
                current = list.Value;
                runner = list.Next.Next.Value;
            }
            if (runner != null)
            {
                current = list.Next.ToString();
            }
            while (current != null)
            {
                if (myStack.Pop() != list.Value)
                    return false;
            }
            return true;
        }

    }
}
