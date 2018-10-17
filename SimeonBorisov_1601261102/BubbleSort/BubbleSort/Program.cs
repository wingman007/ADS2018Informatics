using System;

namespace BubbleSort
{
    class Program
    {

            static void Main(String[] args)
            {
                // Initializing the array
                int[] arr = { 10, 7, 3, 1, 9, 12, 4, 2 };
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

                    // Print array after every pass
                    Console.Write("Step " + i + "  : ");
                    //Printing array after pass
                    Console.WriteLine(String.Join(" ", arr));
                }
            }
        }
    }
