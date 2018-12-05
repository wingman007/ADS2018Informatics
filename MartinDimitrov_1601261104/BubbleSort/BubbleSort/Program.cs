using System;

namespace BubbleSort
{
    class Program
    {
        //Bubble Sort with preset array, you can change the array entries from *
        static void Main(string[] args)
        {
            int[] array = { 9, 42, 46, 14, 44, 5, 16, 2, 31, 27, 56, 56, 78, 1, 999, 1, 97 }; //*here

            int temp;

            //display original array in console
            Console.WriteLine("Original array: ");
            foreach (int oArray in array)
                Console.Write(oArray + " ");

            //Sorting algorithm start
            for (int p = 0; p <= array.Length - 2; p++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1]) //change to < for descending
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            //end

            //display sorted array in console
            Console.WriteLine("\n" + "Sorted array: ");
            foreach (int sArray in array)
                Console.Write(sArray + " ");
            Console.Write("\n");
        }
    }
}