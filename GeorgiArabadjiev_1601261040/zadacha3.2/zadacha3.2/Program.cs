using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4444
{
    class Class1
    {
        static void Main(string[] args)
        {
            int[] arr =     { 800,  771, 700,  240, 649,
                               120, 300, 9, 52, 408, };
            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
                Console.Write("{0} ", arr[write]);
            }

        }
    }
}