using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 23, 44, 66, 76, 98, 11, 3, 9, 7};
            Console.WriteLine("Initial array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            int temp; //temporary variable
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
