using System;

namespace faster_sort
{
    class Program
    {
        static int Partition(int [] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);

            for (int j = low; j <= (high - 1); j++)
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
            return (i + 1);

        }

        static void QuickSort(int []arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, (pi - 1));
                QuickSort(arr, (pi + 1), high);
            }
        }

        static void QuickerSort(int []arr, int low, int high)
        {
            while (low < high)
            {
                int pi = Partition(arr, low, high);

                if ((pi - low) < (high - pi))
                {
                    QuickerSort(arr, low, (pi - 1));
                    low = pi + 1;
                }
                else
                {
                    QuickerSort(arr, (pi + 1), high);
                    high = pi - 1;
                }
            }
        }

        static double FindMedian(int []arr, int n)
        {
            if (n % 2 != 0)
            {
                return (double)arr[n / 2];
            }
            else return (double)(arr[(n - 1) / 2] + arr[n / 2]) / 2.0;
        }

        static void PrintArray(int []arr)
        {
            int i;

            for (i = 0; i < arr.Length; i++)
                Console.Write(arr[i]+" , ");
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 1, 2, 4 };
            int n = arr.Length;
            QuickSort(arr, 0, (n - 1));


            QuickSort(arr, 0, (n - 1));



            Console.WriteLine("Median= " + FindMedian(arr, n));
            Console.WriteLine("Sorted array: ");
            PrintArray(arr);
            Console.WriteLine();

            int[] arr2 = { 9, 6, 8, 7, 5 };
            int m = arr2.Length;
            QuickerSort(arr2, 0, (n - 1));


            QuickerSort(arr2, 0, (n - 1));

            Console.WriteLine("Median= " + FindMedian(arr2, n)); ;
            Console.WriteLine("Sorted array: ");
            PrintArray(arr2);


            Console.ReadLine();





        }
    }
}
