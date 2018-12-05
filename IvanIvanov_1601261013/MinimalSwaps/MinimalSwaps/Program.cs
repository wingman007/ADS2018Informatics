using System;

namespace MinimalSwaps
{
	class Program
	{
		static void Main(string[] args)
		{
			Selection_Sort selection = new Selection_Sort();
			selection.Sort();
		}
	}

	class Selection_Sort
	{
		int counter;
		int[] array = { 1, 5, 8, 3, 7, 10, 9 };

		public void Sort()
		{

			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i] + " | ");
			}

			int temp;

			for (int i = 0; i < array.Length - 1; i++)
			{

				temp = i;

				for (int index = i + 1; index < array.Length; index++)
				{
					if (array[index] < array[temp])
					{
						temp = index;
						counter++;
					}
				}

				Swap(i, temp);
			}

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Sort array");
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i] + " | ");
			}

			Console.WriteLine();
			Console.WriteLine();
			Console.Write("Counter swaps: " + counter);
			Console.WriteLine();

		}

		public void Swap(int first, int second)
		{
			int temporary = array[first];
			array[first] = array[second];
			array[second] = temporary;
		}


	}
}
