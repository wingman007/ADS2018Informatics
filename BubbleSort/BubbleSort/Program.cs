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
           
            Console.WriteLine();
            int[] numbers = new int[GetLength()];

            AssignArray(numbers);
            
            BubbleSortAscending(numbers);

            PrintArray(numbers);

            Console.WriteLine();

            BubbleSortDescending(numbers);

            PrintArray(numbers);

            Console.ReadLine();
        }

        static void Swap(ref int firstNumber, ref int secondNumber)
        {
            int temp = 0;
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }

        static void BubbleSortAscending(int[] array)
        {
            for(int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                    }
                }
            }
        }

        static void BubbleSortDescending(int[] array)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        Swap(ref array[i+1], ref array[i]);
                    }
                }
            }
        }

        static void PrintArray(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
        }

        static void AssignArray(int[] array)
        {
            Console.WriteLine("Please input the numbers of the array : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"[{i}]=");
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        static int GetLength()
        {
            Console.Write("How much numbers? ");
            int length = Convert.ToInt32(Console.ReadLine());

            return length;
        }
    }
}
