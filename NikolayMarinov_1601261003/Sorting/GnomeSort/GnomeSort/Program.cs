using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnomeSort
{
    class Program
    {
        public static void gnomeSort(int[] arr, int n)
        {
            int index = 0;
            while (index < n)
            {
                if (index == 0)
                {
                    index++;
                }
                if (arr[index] >= arr[index - 1])
                {
                    index++;
                }else
                {
                    int temp = 0;
                    temp = arr[index];
                    arr[index] = arr[index - 1];
                    arr[index - 1] = temp;
                    index--;

                }


            }
            return;

        }
        static void Main(string[] args)
        {
            int[] array = {9,7,6,5,4,3,2,1 };

            gnomeSort(array, array.Length);

            Console.WriteLine("Sorted array: ");

            for (int i = 0; i< array.Length; i++)
            {
                Console.Write(array[i] + " ");

            }
        }
    }
}
