using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 42, 46, 14, 44, 5, 16, 2, 31, 27, 56, 56, 78, 1, 999, 1, 97 };
            SortArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void SortArray(int[] array)
        {
            int temp; // darji stoinost za razmqnata
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i]) //v momenta e vazhodqsh ako se smeni na > stava nizhodqsht
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
