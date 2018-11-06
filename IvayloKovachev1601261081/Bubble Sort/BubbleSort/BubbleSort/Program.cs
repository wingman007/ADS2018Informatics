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
            int[] array = { 5, 2, 7, 4, 1, 10, 14, 22, 13, 31 };
            int temp;

            for (int i = array.Length-1; i>= 1; i--)
            {
                for (int j = 0; j<= i -1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            for (int i =0; i< array.Length; i++)
            {
                Console.WriteLine(i + ".: " + array[i]);
            }
            Console.ReadKey();
        }

    }
}
