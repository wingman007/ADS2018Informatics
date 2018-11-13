using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program { 
     private static void QuickSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);

            if (pivot > 1)
            {
                QuickSort(arr, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                QuickSort(arr, pivot + 1, right);
            }
        }

    }

    private static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[left];
        while (true)
        {

            while (arr[left] < pivot)
            {
                left++;
            }

            while (arr[right] > pivot)
            {
                right--;
            }

            if (left < right)
            {
                if (arr[left] == arr[right]) return right;

                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;


            }
            else
            {
                return right;
            }
        }
    }
    static void Main(string[] args)
    {
        int[] arr = new int[] { -6, 5, -4, 10, 0, 18, 100, 500, 21, 32 };

        Console.WriteLine("Original array : ");
        foreach (var item in arr)
        {
            Console.Write(" " + item);
        }
        Console.WriteLine();

        QuickSort(arr, 0, arr.Length - 1);

        Console.WriteLine();
        Console.WriteLine("Sorted array : ");

        foreach (var item in arr)
        {
            Console.Write(" " + item);
        }
        Console.WriteLine();
    }
}
}
