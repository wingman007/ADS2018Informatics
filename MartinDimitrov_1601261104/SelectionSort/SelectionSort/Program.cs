using System;

namespace SelectionSort
{
    class Program
    {
        //Selection Sort with preset array, you can change the array entries from *
        static void Main(string[] args)
        {
            int[] array = { 25,29,31,5,14,1001,420,35,46,42 }; //*here

            int temp, min_key;

            //display original array in console
            Console.WriteLine("Original array: ");
            foreach (int oArray in array)
                Console.Write(oArray + " ");

            //Sorting algorithm start
            for (int j = 0; j < array.Length - 1; j++)
            {
                min_key = j;

                for (int k = j + 1; k < array.Length; k++) 
                {
                    if (array[k] < array[min_key]) // change to > for descending and vice versa
                    {
                        min_key = k;
                    }
                }

                temp = array[min_key];
                array[min_key] = array[j];
                array[j] = temp;
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