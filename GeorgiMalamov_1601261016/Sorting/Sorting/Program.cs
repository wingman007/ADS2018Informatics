using System;
using System.Diagnostics;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new[] { 1, 20, 15, 111, 2, 33, 4, 5, 90, 7, 12, 45,1111,2231,13131,144,11,-2,-4,4,777,12 };

            Console.WriteLine("Original Array: " + string.Join(",", Array));


            // stopwatch for checking the time it takes to sort (or atleast I hope it works!)
            Stopwatch watch = new Stopwatch();
            double timePassed;  // time in second, accurate to about millseconds

            watch.Reset();
            watch.Start();
            BubbleSort(Array);
            watch.Stop();
            timePassed = watch.ElapsedMilliseconds / 1000.0; // 1sec == 0,001 ms
            Console.WriteLine("BubbleSort time: {0:F4}", timePassed);

            watch.Reset();
            watch.Start();
            InsertionSort(Array);
            timePassed = watch.ElapsedMilliseconds / 1000.0; // 1sec == 0,001 ms
            Console.WriteLine("InsertionSort time: {0:F4}", timePassed);
        }


        // simple buble sort
        public static void BubbleSort(int[] Arr)
        {
            int i, j;
            int N = Arr.Length;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (Arr[i] > Arr[i + 1])
                    {
                        int temp = Arr[i];
                        Arr[i] = Arr[i + 1];
                        Arr[i + 1] = temp;
                    }
                }
            }
            // print
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("After BubbleSort: " + string.Join(",", Arr));
            Console.WriteLine("-----------------------------------------------");
        }
        
        // insertion sorting
        public static void InsertionSort(int[] ArrTemp)
        {
            
            for (int j = 1;  j < ArrTemp.Length; j++)
            {
                for (int i = j; i > 0 && ArrTemp[i] < ArrTemp[i - 1]; i--)
                {

                    int temp = ArrTemp[i];
                    ArrTemp[i] = ArrTemp[i - 1];
                    ArrTemp[i - 1] = temp;

                }

            }
            // print
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("After InsertionSort: " + string.Join(",", ArrTemp));
            Console.WriteLine("-----------------------------------------------");

        }
    }
}
