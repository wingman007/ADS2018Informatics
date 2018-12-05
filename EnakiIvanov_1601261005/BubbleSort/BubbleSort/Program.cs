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
			int[] arr = { 8, 1, 2, 7, 3, 6, 4, 5, 10, 9 };

			int temp = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				for (int sort = 0; sort < arr.Length - 1; sort++)
				{
					if (arr[sort] > arr[sort + 1])
					{
						temp = arr[sort + 1];
						arr[sort + 1] = arr[sort];
						arr[sort] = temp;
					}
				}
			}

			for (int i = 0; i < arr.Length; i++)
				Console.Write(arr[i] + " ");

			Console.ReadKey();
		}
	}
}
