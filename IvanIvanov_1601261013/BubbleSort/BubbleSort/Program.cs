using System;

namespace BubbleSort
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = { 1500, 1, 50, 5, 123, 2, 240, 25 };

			int temp = 0;

			for(int i = 0; i < array.Length; i++)
			{
				for(int j = 0; j < array.Length - 1; j++)
				{
					if (array[j] > array[j + 1])
					{
						temp = array[j + 1];
						array[j + 1] = array[j];
						array[j] = temp;
					}
				}
			}

			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine("Element " + i + " = " + array[i]);
			}

		}
	}
}
