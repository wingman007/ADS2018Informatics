using System;
using System.Diagnostics;

namespace SortingComparison
{
    class Program
    {

        static void insertionSort(int[] arr, int n)
        {
            Stopwatch stopwatch = new Stopwatch();
            int i, key, j;
            stopwatch.Start();
            for (i = 0; i < n; i++)
            {
                key = arr[i];
                j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            stopwatch.Stop();
            Console.WriteLine("Insertion sort with " + n + " elements took: " + stopwatch.Elapsed);
        }

        static void BubbleSort(int[] arr, int n)
        {
            Stopwatch stopwatch = new Stopwatch();
            int i, j, temp;
            stopwatch.Start();
            for (i = 0; i < n - 1; i++)
            {

                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Bubble sort with " + n + " elements took: " + stopwatch.Elapsed);


        }

        static void SelectionSort(int[] arr, int n)
        {
            Stopwatch stopwatch = new Stopwatch();

            int i, j, min_idx, temp;

            stopwatch.Start();

            for (i = 0; i < n - 1; i++)
            {
                min_idx = i;

                for (j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;
                    }
                    temp = arr[min_idx];
                    arr[min_idx] = arr[i];
                    arr[i] = temp;
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Selection sort with " + n + " elements took: " + stopwatch.Elapsed);
        }

        static void printArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
                Console.WriteLine("arr[" + i + "]: " + arr[i]);
            Console.WriteLine("\n");
        }
        static int[] PopulateArray(int size)
        {

            Random rnd = new Random();
            int num;
            int[] arr = new int[size];
            Console.WriteLine("\nPopulating array .... ");
            for (int i = 0; i < size; i++)
            {
                num = rnd.Next(1, 1000);
                arr[i] = num;
            }
            return arr;

        }

        static void Main(string[] args)
        {

            int EleCount = 10000;

            int[] arr = PopulateArray(EleCount);
            int size = arr.Length;

            arr = PopulateArray(EleCount);
            insertionSort(arr, size);

            arr = PopulateArray(EleCount);
            BubbleSort(arr, size);

            arr = PopulateArray(EleCount);
            SelectionSort(arr, size);
        }
    }
}