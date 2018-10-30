using System;

namespace InsertionSort
{
    class Program
    {
        // Function to sort array  
        // using insertion sort/ 
        void sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], 
                // that are greater than key,  
                // to one position ahead of 
                // their current position 
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        // function to print 
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.Write("\n");
        }
        static void Main(string[] args)
        {
            int[] arr = { 3490, 200, 156, 10, 2 };
            Program ob = new Program();
            ob.sort(arr);
            printArray(arr);

        }
    }
}
