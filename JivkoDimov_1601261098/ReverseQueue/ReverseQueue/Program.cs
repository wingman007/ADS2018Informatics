using System;
using System.Collections.Generic;

class ReverseQueue
{
    static void printQueue(Queue<long> queue)
    {
        while (queue.Count != 0)
        {
            Console.Write(queue.Peek() + " ");
            queue.Dequeue();
        }
    }
 
    static void reverseQueue(ref Queue<long> q)
    { 
        if (q.Count == 0)
            return;

        long data = q.Peek();
        q.Dequeue();

        reverseQueue(ref q);

        q.Enqueue(data);
    }

    static void Main()
    {
        Queue<long> queue = new Queue<long>();
        queue.Enqueue(1);
        queue.Enqueue(5);
        queue.Enqueue(10);
        queue.Enqueue(45);
        queue.Enqueue(85);
        queue.Enqueue(92);
        queue.Enqueue(58);
        queue.Enqueue(80);
        queue.Enqueue(90);
        queue.Enqueue(100);
        reverseQueue(ref queue);
        printQueue(queue);
    }
}