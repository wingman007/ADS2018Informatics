using System;

namespace CombinedQuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете размера на произволен масив: ");
            int n;
            do
            {
                Console.Write("\nВъведете размера на масива(Max 1000):");
                n = int.Parse(Console.ReadLine());
                if (n > 1000)
                {
                    Console.Write("Въведете малко число!");
                }
                else
                {
                    int[] a = new int[n];
                    FillArray(a);
                    PrintArray(a);
                    if (a.Length > 20)
                    {
                        Console.WriteLine("\nUsing Quick Sort: ");
                        QuickSort(a, 0, a.Length - 1);
                        PrintArrayQS(a);
                    }
                    else if (a.Length <= 20)
                    {
                        Console.Write("\nUsing Insertion Sort: ");
                        InsertionSort(a, 0, a.Length - 1);
                        PrintArrayIS(a);
                    }
                }
            } while (n > 1000);
        }

        static void QuickSort(int[] a, int start, int end)
        {
            if (start < end)
            {
                int pIndex = Partition(a, start, end);

                QuickSort(a, start, pIndex - 1);
                QuickSort(a, pIndex + 1, end);
            }
        }

        static int Partition(int[] a, int start, int end)
        {
            int pivot = a[end];
            int pIndex = start;

            for (int i = start; i < end; i++)
            {
                if (a[i] <= pivot)
                {
                    SwapInts(a, i, pIndex);
                    pIndex++;
                }
            }
            SwapInts(a, pIndex, end);

            return pIndex;
        }
        static void SwapInts(int[] array, int position1, int position2)
        {

            int temp = array[position1];
            array[position1] = array[position2];
            array[position2] = temp;
        }

        static void FillArray(int[] a)
        {
            Random rand = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(1000);
            }
        }

        static void PrintArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }


        static void PrintArrayQS(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }

        static void InsertionSort(int[] list, int start, int end)
        {
            for (int x = start + 1; x < end; x++)
            {
                int val = list[x];
                int j = x - 1;
                while (j >= 0 && val < list[j])
                {
                    list[j + 1] = list[j];
                    j--;
                }
                list[j + 1] = val;
            }
        }


        static void PrintArrayIS(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
 