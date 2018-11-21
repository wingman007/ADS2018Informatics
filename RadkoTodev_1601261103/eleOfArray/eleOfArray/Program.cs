using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eleOfArray
{
    class Program
    {



        public static int maxPosition = 0;



        public static void Main(String[] args)
        {
            Console.WriteLine("Visualise Array");

            int[] array = new int[] { 7, 35, 90, 22, 17, 11, 25 };
            VisualiseArray(array);
            FindMinAndMax(array);

            Sort(array, 7);
            Pyramid(array);

            Console.ReadKey();
        }

        private static void VisualiseArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write((arr[i] + " "));
            }

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("\n------------------------------");
        }

        private static void FindMinAndMax(int[] arr)
        {
            Console.WriteLine("Find Min ");
            int min = arr[0];
            int max = 0;
            for (int i = 0; (i < arr.Length); i++)
            {
                if ((min > arr[i]))
                {
                    min = arr[i];
                }

                if ((max < arr[i]))
                {
                    max = arr[i];
                }

            }

            for (int i = 0; (i < arr.Length); i++)
            {
                if ((max == arr[i]))
                {
                    maxPosition = i;
                }

            }

            Console.WriteLine("Min number is " + min);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("------------------------------");
        }

        private static void Sort(int[] arr, int n)
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Sorting");

            Array.Sort(arr);
            for (int i = 0; (i < n); i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("\n------------------------------");
        }




        private static void Pyramid(int[] arr)
        {

            Console.WriteLine("Pyramid");
            Console.WriteLine(Environment.NewLine);
            int num = arr[0];
            for (int i = 0; (i < arr.Length); i++)
            {
                for (int j = 0; (j <= i); j++)
                {
                    num = arr[j];
                    Console.Write(num + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(Environment.NewLine + "------------------------------");
        }

    }
}