using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 100, 32, 45, 67, 45, 67, 89, 93, 56, 23, 56, 56, 78, 1000, 10, 1, 97 };
            SortArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void SortArray(int[] array)
        {
            int temp; // keeps the value for the swap
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
