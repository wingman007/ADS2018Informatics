using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 5, 1, 7, 3, 8, 9 };

            int i, j;
            int N = data.Length;

            for (i = 1; i < N; i++)
            {
                for (j = i; j > 0 && data[j] < data[j - 1]; j--)
                {
                    exchange(data, j, j - 1);
                }
            }

            foreach (var item in data)
            {
                Console.Write(item + "  ");
            }

            Console.WriteLine();
        }

        public static void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }
    }
}
