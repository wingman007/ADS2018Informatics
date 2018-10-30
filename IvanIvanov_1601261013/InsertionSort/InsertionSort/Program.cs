using System;

namespace InsertionSort
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = { 1500, 1, 50, 5, 123, 2, 240, 25, 11, 7 };

			int j;
			int temp;
			

			for (int i = 0; i < array.Length; i++)
			{
				j = i - 1;

				while (j >= 0 && array[j] > array[j + 1])
				{
					temp = array[j];
					array[j] = array[j + 1];
					array[j + 1] = temp;

					j -= 1;
					
				}
			}

			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine("Element " + i + " = " + array[i]);
			}
			
		}
	}
}
