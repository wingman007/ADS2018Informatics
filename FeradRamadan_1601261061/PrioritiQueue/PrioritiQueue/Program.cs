using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Priority_Queue;

namespace Priority_Queue
{
    public static class SimplePriorityQueueExample
    {
        public static void RunExample()
        {
            //First, we create the priority queue.
            SimplePriorityQueue<string> priorityQueue = new SimplePriorityQueue<string>();

            //Now, let's add them all to the queue (in some arbitrary order)!
            priorityQueue.Enqueue("Наков-1998", 0);
            priorityQueue.Enqueue("Уирт-1980", 1);


            //Change one of the string's priority to 2.  Since this string is already in the priority queue, we call UpdatePriority() to do this
            priorityQueue.UpdatePriority("Наков-1998", 2);

            //Finally, we'll dequeue all the strings and print them out
            while (priorityQueue.Count != 0)
            {
                string nextUser = priorityQueue.Dequeue();
                Console.WriteLine(nextUser);
            }


        }
    }
}