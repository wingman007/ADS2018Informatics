using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new[] { 1,20,15,111, 2, 4, 5, 7, 12, 45 };

            Console.WriteLine("Original Array:" + string.Join(",", Array));

            BubbleSort(Array);
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
                    if (Arr[i] > Arr[i + 1]) {
                        int temp = Arr[i];
                        Arr[i] = Arr[i + 1];
                        Arr[i + 1] = temp;
                    }
                }
            }
            // print
            Console.WriteLine("After Sort:" + string.Join(",", Arr));
        }
    }
}
