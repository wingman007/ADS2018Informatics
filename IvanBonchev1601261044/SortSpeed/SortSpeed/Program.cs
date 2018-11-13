using System;

namespace SortSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number for array size:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter arr[" + i + "]:");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            BubbleSort(arr);
            SelectionSort(arr);
            Console.ReadLine();

        }



        static void BubbleSort(int[] array)
        {

            Console.WriteLine("Before Bubble Sort ");
            Console.WriteLine(DateTime.Now.ToString("hh.mm.ss.ffffff"));
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length - 2; j++)
                {

                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }

            }
            Console.WriteLine("......");
            Console.WriteLine("After Bubble Sort");
            Console.WriteLine(DateTime.Now.ToString("hh.mm.ss.ffffff"));

        }


        static void SelectionSort(int[] arr)
        {

            int b = 0;
            Console.WriteLine("Before Selection Sorting");
            Console.WriteLine(DateTime.Now.ToString("hh.mm.ss.ffffff"));

            for (int i = 1; i < arr.Length; i++)
            {
                b = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > b)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = b;
            }
            Console.WriteLine("......");
            Console.WriteLine("After Selection Sorting");
            Console.WriteLine(DateTime.Now.ToString("hh.mm.ss.ffffff"));
        }
    }
}
