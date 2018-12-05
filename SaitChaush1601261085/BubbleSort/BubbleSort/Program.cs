using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                
                int[] arr = { 18, 7, 15, 1, 4, 9, 6, 2 };
                Console.Write("Starting array : ");
                Console.WriteLine(String.Join(" ", arr));
                bubbleSort(arr);
            }
         
            static void bubbleSort(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }

                    
                    Console.Write("Step " + i + "  : ");
                    
                    Console.WriteLine(String.Join(" ", arr));
                }
            }
        }
    }
}
 }