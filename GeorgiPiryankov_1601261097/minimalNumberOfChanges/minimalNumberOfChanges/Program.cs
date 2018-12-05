using System;

namespace minimalNumberOfChanges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unsorted array: \n");
            int[] arr = new int[] { 2, 1, 3 };
            foreach (var item in arr)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("\nSorted array with minimal number of changes: \n");
            var tmp = arr[0];
            arr[0] = arr[1];
            arr[1] = tmp;
            foreach (var item in arr)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
