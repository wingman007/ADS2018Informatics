using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 23, 44, 66, 76, 98, 11, 3, 9, 7};
            Console.WriteLine("Initial array: ");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i < arr.Length; i++)
            {
                int inserValue = arr[i];
                int inserIndex = i - 1;
                while (inserIndex >= 0 && inserValue < arr[inserIndex])
                {

                    arr[inserIndex + 1] = arr[inserIndex];
                    inserIndex--;
                }
                arr[inserIndex + 1] = inserValue;
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