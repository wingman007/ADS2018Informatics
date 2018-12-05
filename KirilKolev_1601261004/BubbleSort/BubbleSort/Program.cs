using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 15, 47, 5, 1, 45, 44, 68, 12, 35, 24 };

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
