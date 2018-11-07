using System;

namespace CombSort
{
    class Program
    {
        // finding the gap between the elements 
        static int getNextGap(int gap)
        {
            gap = (gap * 10) / 13;
            if (gap < 1)
                return 1;
            return gap;
        }

        // Function to sort arr[] 
        static void sort(int[] arr)
        {
            int n = arr.Length;
            int gap = n; 
            bool swapped = true;
            
            while (gap != 1 || swapped == true)
            {
                // Find next gap 
                gap = getNextGap(gap);

                swapped = false;

                for (int i = 0; i < n - gap; i++)
                {
                    if (arr[i] > arr[i + gap])
                    {
                        // Swap arr[i] and arr[i+gap] 
                        int temp = arr[i];
                        arr[i] = arr[i + gap];
                        arr[i + gap] = temp;

                        // Set swapped 
                        swapped = true;
                    }
                }
            }
        }
        public static void Main(string[] args)
        {
            int[] arr = { 8, 4, 1, 56, 3, -44, 23, -6, 28, 0 };
            sort(arr);

            Console.WriteLine("sorted array");
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
            Console.ReadKey(); // stopping the code for continuing = placing a breakpoint
        }
    }
 }
