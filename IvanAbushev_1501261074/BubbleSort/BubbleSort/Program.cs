using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6] { 3, 5, 7, 6, 4, 8 };
            int temp = 0;

            for (int i = 0;i < arr.Length;i++)
          {
                for (int j = 0; j < arr.Length; j++)
             {
                    if (arr[i] < arr[j])
                {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
               }
           }
       }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0},", arr[i]);
            }
        }
    }
}










