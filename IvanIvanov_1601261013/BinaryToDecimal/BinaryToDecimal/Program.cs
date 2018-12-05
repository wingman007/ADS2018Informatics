using System;

namespace BinaryToDecimal
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter a binary number: ");
			string binaryNumber = Console.ReadLine();

			char[] array = binaryNumber.ToCharArray();

			Array.Reverse(array);

			int sum = 0;

			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == '1')
				{
					if (i == 0)
					{
						sum += 1;
					}
					else
					{
						sum += (int)Math.Pow(2, i);
					}
				}
			}

			Console.WriteLine("Result: " + sum);
		}
	}
}
