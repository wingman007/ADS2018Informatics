using System;
using System.Threading;

namespace QuickSort
{
	class Program
	{
		static void Main(string[] args)
		{

			int[] a = new int[1000];
			FillArray(a);
			PrintArray(a);
			Console.WriteLine();
			QuickSort(a,0, a.Length-1);
			PrintArray(a);


		}

		static void QuickSort(int[] a, int start, int end)
		{
			if(start < end)
			{
				int pIndex = Partition(a, start, end);

				QuickSort(a, start, pIndex - 1);
				QuickSort(a, pIndex + 1, end);
			}
		}

		static int Partition(int[] a, int start, int end)
		{
			int pivot = a[end];
			int pIndex = start;

			for (int i = start; i < end; i++)
			{
				if( a[i] <= pivot )
				{
					SwapInts(a, i, pIndex);
					pIndex++;
				}
			}
			SwapInts(a, pIndex, end);

			return pIndex;
		}
		static void SwapInts(int[] array, int position1, int position2)
		{

			int temp = array[position1]; 
			array[position1] = array[position2]; 
			array[position2] = temp; 
		}

		static void FillArray(int[] a)
		{
			Random rand = new Random();
			for (int i = 0; i < a.Length; i++)
			{
				a[i] = rand.Next(1000);
			}
		}

		static void PrintArray(int[] a)
		{
			for (int i = 0; i < a.Length; i++)
			{
				Console.Write(a[i] + " ");
			}
		}
	}
}
