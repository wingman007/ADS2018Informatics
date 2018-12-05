using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Sort
    {
        static void Main(string[] args)
        {
            Console.Write("Number of an array elements: ");
            int elementNumber = int.Parse(Console.ReadLine());
            int[] array = new int[elementNumber];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Element " + (i + 1) + ": ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Choose 1(BubbleSort) or 0(Exit): ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    BubbleSort(array);
                    break;
                case 0:

                    return;
                default:
                    Console.WriteLine("Wrong choice!");
                    break;

            }
            Console.ReadLine();
        }

        static void BubbleSort(int[] array)
        {
            {
                int length = array.Length;

                int temp = array[0];

                for (int i = 0; i < length; i++)
                {
                    for (int j = i + 1; j < length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            temp = array[i];

                            array[i] = array[j];

                            array[j] = temp;
                        }
                    }
                }
                Console.Write("Sorted array: ");
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
