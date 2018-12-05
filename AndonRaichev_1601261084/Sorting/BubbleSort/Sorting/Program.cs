using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
       static void  bubbleSort( int [] arr )
        {
            int temp;
            for ( int i = 0; i < arr.Length-1; ++i)
                for( int j = 0; j < arr.Length - i - 1; ++j )
                {
                    if ( arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            for ( int i = 0; i < arr.Length; ++i )
                Console.Write( arr[i] + " " );

            Console.WriteLine();
        }
  
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 3, 2, 0, 66, 23, 12, 6 };
            bubbleSort(arr);
        }
    }
}
