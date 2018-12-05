using System;
using System.Linq;

namespace MinimumSteps
{
    class Program
    {
         
    static int minMoves(int[] arr, int n)
        {
            
            int expectedItem = n;

            
            for (int i = n - 1; i >= 0; i--)
            {
               
                
                if (arr[i] == expectedItem)
                    expectedItem--;
            }

            return expectedItem;
        }

        
        public static void Main()
        {
            int[] arr = { 3, 1, 2, 4 };
            int n = arr.Length;
            Console.Write(minMoves(arr, n));
             
        }
    }
}
