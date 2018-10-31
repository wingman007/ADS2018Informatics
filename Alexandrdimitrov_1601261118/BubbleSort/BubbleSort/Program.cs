using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 15, 40, 5, 1, 86, 53, 120, 166, 35, 20, 100, 200 };

            int temp = 0;

            for ( int write = 0; write < arr.Length; write++ )
            {
                for ( int sort = 0; sort < arr.Length - 1; sort++ )
                {
                    if ( arr[sort] > arr[sort + 1] )
                    {
                        temp            =   arr[sort + 1];
                        arr[sort + 1]   =   arr[sort];
                        arr[sort]       =   temp;
                    }
                }
            }

            for ( int i = 0; i < arr.Length; i++ )
            {
                Console.Write( arr[i] + " " );
            }
        }
    }
}
