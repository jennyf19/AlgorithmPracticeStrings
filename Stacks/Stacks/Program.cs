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
                    "\n\t5." +
                    "\n\t0.Exit App");
                Console.Write("\nEnter your selection: ");

                int selection;
                //TryParse will check input...if not an integer, int selection = 0, app will exit
                int.TryParse(Console.ReadLine(), out selection);

                switch (selection)
                {
                    case 1:  //display queue
                        
                        break;

                    case 2:  //enqueue
                        
                        break;

                    case 3: //dequeue
                        
                        break;

                    case 4:   //peek
                        
                        break;

                    case 5:  //merege queue1 and queue2 alternating between them
                        
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
    }
}
