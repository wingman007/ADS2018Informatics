using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 8, 30, 278, 612, 449, 311, 2, 999 };

            SortArray(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
            static void SortArray(int[] array)
            {
                int temp = 0;
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
