using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 999, 1, 22, 4, 2, 120, 3213, 35, 23, 24 };

            BubbleSort<int>(arr);

            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i] + " ");
            }
        }

        static void BubbleSort<T>(T[] arr) where T : IComparable {
            if (arr.Length == 1) {
                return;
            }

            int upper = (int)Math.Ceiling(Math.Sqrt((double)arr.Length)) + 1;
            for (int i = 0; i < arr.Length - 1; i++) {
                int j = i + 1;
                while (j > 0 && arr[j - 1].CompareTo(arr[j]) == 1)
                {
                    T temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    j--;
                }
            }
        }

        //static void MergeSort<T>(T[] arr)
        //{
        //    //MergeSort<T>(arr, 0, arr.Length - 1);
        //}

        //static void MergeSort<T>(T[] arr, int start, int end) where T : IComparable
        //{

        //    for (int i = start; i <= end; i++)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }
        //    Console.WriteLine();

        //    if (end == start)
        //    {
        //        return;
        //    }
        //    else if (end - start == 1)
        //    {
        //        int res = arr[start].CompareTo(arr[end]);
        //        if (res == 1)
        //        {
        //            T temp = arr[start];
        //            arr[start] = arr[end];
        //            arr[end] = temp;
        //        }
        //    }
        //    else
        //    {
        //        int middle = (end - start) / 2;
        //        MergeSort(arr, start, middle - 1);
        //        MergeSort(arr, middle, end);

        //        int left = start;
        //        int right = middle;
        //        for (int i = start; i < end; i++) {
        //            if (arr[left].CompareTo(arr[right]) == 1)
        //            {
        //                arr[i] = arr[left];
        //            }
        //            else {
        //            }
        //        }
        //    }
        //}
    }
}
