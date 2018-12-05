using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int[] list = new int[5];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = ran.Next(0, 100);
            }

            Write(list);
            Console.Write("\n--------------------\n");
            SelectionSort(list);
            Write(list);

            Console.ReadKey();
        }

        static int[] SelectionSort(int[] array)
        {
            int count, temp;
            count = array.Length;
            for(int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if(array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        static void Write(int[] array)
        {
            foreach(var item in array)
            {
                Console.Write("{0, -3}", item);
            }
        }

    }
}
