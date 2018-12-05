using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static void Insert( List<object>Queue , object obj )
        {
            if(Queue.Count == 0)
            {
                Queue.Add(obj);
                return;
            }
           foreach( var param in Queue  )
            {
                if ( param.GetType() == obj.GetType() )
                {
                    Queue.Insert(Queue.IndexOf(param) + 1, obj);
                    return;
                }
               
            }
            Queue.Insert(Queue.Count, obj);
        }

        public static void Print(List<object> Queue)
        {
            foreach (var param in Queue)
            {
                Console.Write(param);
            }
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            List<object> Queue = new List<object>();
            Insert(Queue, "a");
            Insert(Queue, 22);
            Insert(Queue, true);
            Insert(Queue, "b");
            Insert(Queue, 15);
            Print( Queue );
          

        }
    }
}
