using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array1 = { 3, 9, 5, 12, 20, 15, 11, 6, 17 };
            Queue<int> queue1 = new Queue<int>(array1);

            int[] array = { 3, 9, 5, 12, 20, 15, 11, 6, 17 };
            int[] array2 = { -5, -2, -12, -22, -19, -12, -15, -7 };

            //create new queue and pass it this array
            //IEnumberable means it has to inherit something 
            Stack<int> stack1 = new Stack<int>(array);
            Stack<int> stack2 = new Stack<int>(array2);
            

            while (true)
            {
                //display menu
                //clear display
                Console.Clear();

                Console.WriteLine("\n\n\t1.Display" + "\n\t2.Push" + "\n\t3.Pop" + "\n\t4.Peek" +
                    "\n\t5.Merge" +  "\n\t6.Input Queue" +
                    "\n\t0.Exit App");
                Console.Write("\nEnter your selection: ");

                int selection;
                //TryParse will check input...if not an integer, int selection = 0, app will exit
                int.TryParse(Console.ReadLine(), out selection);

                switch (selection)
                {
                    case 1:  //display stack
                        DisplayStack(stack1);
                        DisplayStack(stack2);
                        break;

                    case 2:  //push
                        PushToStack(stack1);
                        PushToStack(stack2);
                        break;

                    case 3: //pop
                        PopFromStack(stack1);
                        PopFromStack(stack2);
                        break;

                    case 4:   //peek
                        PeekAtTheStack(stack1);
                        PeekAtTheStack(stack2);
                        break;

                    case 5:  //merege queue1 and queue2 alternating between them
                        DisplayStack(stack1);
                        DisplayStack(stack2);
                        Stack<int> stack = Merge(stack1, stack2);
                        Console.WriteLine();
                        DisplayStack(stack);
                        break;

                    case 6:
                        //Write a method that takes a queue and returns a stack
                        //such that the first element in the queue is saved at the top of the stack
                        Stack<int> s = ConvertQueueToStack(queue1);
                        DisplayStack(s);
                        break;

                    case 0:
                        return;

                    default:
                        break;

                }//end of switch

                //pause it
                Console.WriteLine("\n\nHit 'Enter' to continue");
                Console.ReadLine();

            }//end of while loop


        }
        static void DisplayStack(Stack<int> stack)
        {
            Console.WriteLine("\nStack content: ");
            foreach (int x in stack)
            {
                Console.WriteLine("\t" + x);
            }
        }

        static void PushToStack(Stack<int> stack)
        {
            bool done;
            int value;
            do
            {
                Console.WriteLine("Enter a number to push to the stack: ");
                done = int.TryParse(Console.ReadLine(), out value);
            }
            while (!done);

            stack.Push(value);
            DisplayStack(stack);
        }

        static void PopFromStack(Stack<int> stack)
        {
            DisplayStack(stack);
            int popValue = stack.Pop();
            Console.WriteLine("\n{0} was popped from the stack", popValue);
            DisplayStack(stack);
        }

        static void PeekAtTheStack(Stack<int> stack)
        {
            int top = stack.Peek();
            Console.WriteLine("\nvalue: {0} is at the top of the stack", top);
        }

        static Stack<int> Merge(Stack<int> s1, Stack<int> s2)
        {
            Stack<int> s = new Stack<int>(s1.Count + s2.Count);

            while (s1.Count > 0 && s2.Count > 0)
            {
                int popItem1 = s1.Pop();
                s.Push(popItem1);
                int popItem2 = s2.Pop();
                s.Push(popItem2);
            }
            while (s1.Count > 0)
            {
                int popItem1 = s1.Pop();
                s.Push(popItem1);
            }
            while (s2.Count > 0)
            {
                int popItem2 = s2.Pop();
                s.Push(popItem2);
            }

            //reverse stack s, without reverse method
            Stack<int> rs = new Stack<int>(s.Count);

            while(s.Count > 0)
            {
                rs.Push(s.Pop());
            }
            return rs;
        }
        static Stack<int> ConvertQueueToStack(Queue<int> q)
        {
            Stack<int> s = new Stack<int>(q.Count);
            foreach (int x in q)
            {
                s.Push(x);
            }
            
            Stack<int> rs = new Stack<int>(s.Count);
            while (s.Count>0)
            {
                rs.Push(s.Pop());
            }
            return rs;
        }


    }


}
