using System;

namespace ConsoleApplication13
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] a = { 5, 3, 6, 4, 2, 9, 1, 8, 7 };


			// Print the unsorted array
			Console.WriteLine("Unsorted array:");
			for (int i = 0; i < a.Length; i++)
			{
				Console.Write(a[i]);
			}


			// Sort the array
			Console.Write(Environment.NewLine);

			QuickSort(a, 0, a.Length - 1);


			// Print the sorted array
			Console.Write("Sorted array:" + Environment.NewLine);
			for (int i = 0; i < a.Length; i++)
			{
				Console.Write(a[i]);
			}

			Console.WriteLine();

			Console.ReadLine();
		}



		static void QuickSort(int[] a, int start, int end)
		{
			if (start >= end)
			{
				return;
			}

			int num = a[start];

			int i = start, j = end;

			while (i < j)
			{
				while (i < j && a[j] > num)
				{
					j--;
				}

				a[i] = a[j];

				while (i < j && a[i] < num)
				{
					i++;
				}

				a[j] = a[i];
			}

			a[i] = num;
			QuickSort(a, start, i - 1);
			QuickSort(a, i + 1, end);
		}
	}
}