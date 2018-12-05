using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 800, 11, 50, 771, 641, 889, 346, 9 };
            int temp = 0;
            for (int i = 0; i < array.Length; i++) {

                for (int j = 0; j < array.Length - 1; j++) {

                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
