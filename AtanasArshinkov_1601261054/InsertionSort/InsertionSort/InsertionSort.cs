using System;
using System.Collections.Generic;

namespace InsertionSort
{
    class InsertionSort
    {
        static void Main(string[] args)
        {
            int[] arr = {-2, 8, 1, 2, 6, -7, 40, 23, 5, 34};
            Sort(arr);
            PrintArray(arr);
        }

        private static void Sort(IList<int> arr)
        {
            for (var i = 1; i < arr.Count; ++i)
            {
                var key = arr[i];
                var j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
            }
        }

        private static void PrintArray(IReadOnlyList<int> arr)
        {
            var n = arr.Count;
            for (var i = 0; i < n - 1; ++i)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
    }
}