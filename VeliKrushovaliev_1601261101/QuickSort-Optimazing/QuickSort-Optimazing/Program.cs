using System;
using System.Diagnostics;

namespace QuickSort_Optimazing
{


    class GFG
    {

        static int partition(int[] arr, int low,
                                       int high)
        {
            int pivot = arr[high];


            int i = (low - 1);
            for (int j = low; j < high; j++)
            {

                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }




        static void quickSort(int[] arr, int low, int high)
        {

            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partition(arr, low, high);


                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }

        }

        static void quickerSort(int[] arr, int low, int high)
        {
            while (low < high)
            {
                /* pi is partitioning index, arr[p] is now 
                   at right place */
                int pi = partition(arr, low, high);


                if (pi - low < high - pi)
                {
                    quickSort(arr, low, pi - 1);
                    low = pi + 1;
                }
                else
                {
                    quickSort(arr, pi + 1, high);
                    high = pi - 1;
                }
            }
        }

        static void printArray(int[] arr, int n)
        {
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }


        public static void Main()
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            quickSort(arr, 0, n - 1);
            Console.WriteLine("\nnormal quick sort took: " + stopwatch.Elapsed + "\n");
            Console.WriteLine("sorted array ");
            printArray(arr, n);

            stopwatch.Reset();
            stopwatch.Start();
            int[] arr2 = { 10, 7, 8, 9, 1, 5 };
            quickerSort(arr2, 0, n - 1);
            Console.WriteLine("\nquicker sort took: " + stopwatch.Elapsed + "\n");
            Console.WriteLine("sorted array ");
            printArray(arr2, n);

        }
    }
}
