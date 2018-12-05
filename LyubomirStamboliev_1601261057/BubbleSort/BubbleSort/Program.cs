using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBubbleSort
{
    class Class1
    {
        static void Main(String[] args)
        {


            int[] arr = { 100, 38, 50, 71, 69, 20, 25, };

            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");

            Console.ReadKey();
        }
    }
}
