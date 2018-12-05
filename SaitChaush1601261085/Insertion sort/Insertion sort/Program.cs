using System;

namespace Insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] arr = { 34, 2, 10, 50 };

                int index = 0;

                while (index < arr.Length)
                {
                    if (index == 0)
                        index++;
                    if (arr[index] >= arr[index - 1])
                        index++;
                    else
                    {
                        int temp = 0;
                        temp = arr[index];
                        arr[index] = arr[index - 1];
                        arr[index - 1] = temp;
                        index--;
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }
        }
    }
}