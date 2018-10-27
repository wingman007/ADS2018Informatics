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
            int[] list = { 23, 44, 66, 76, 98, 11, 3, 9, 7 };

            Console.WriteLine("Initial list: ");
            foreach (int i in list)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            InsertionSort(ref list);

            Console.WriteLine("Sorted list: ");
            foreach (int i in list)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.ReadLine();
        }

        public static void InsertionSort(ref int[] list)
        {
            for (int i = 1; i < list.Length; i++)
            {
                int intToEval = list[i];
                int j = i;

                while (j > 0 && intToEval < list[j - 1])
                {
                    list[j] = list[j - 1];
                    list[j - 1] = intToEval;
                    j--;
                }
            }
        }
    }
}