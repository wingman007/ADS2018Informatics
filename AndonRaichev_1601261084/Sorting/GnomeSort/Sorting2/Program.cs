using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting2
{
    class Program
    {
        static void gnomeSort( int[] arr )
        {
            int index = 0;
            int temp;
        
            while ( index < arr.Length )
            {
                if ( index == 0 )
                    index++;
                if ( arr[index] >= arr[index - 1] )
                    index++;
                else
                {
                    temp = arr[index];
                    arr[index] = arr[index - 1];
                    arr[index - 1] = temp;
                    index--;
                }
            }

            for ( int i = 0; i < arr.Length; i++ )
                Console.Write(arr[i] + " ");
        }

        static void Main(string[] args)
        {
            int[] arr = { 22, 2, 1, 5, 14, 6, 8 };

            gnomeSort( arr );
        }
    }
}
