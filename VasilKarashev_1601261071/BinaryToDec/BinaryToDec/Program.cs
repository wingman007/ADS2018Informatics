using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{


			Console.WriteLine("Write binary number:");
			string BinaryToDec = Console.ReadLine();
			char[] array = BinaryToDec.ToCharArray();
			// Reverse since 16-8-4-2-1 not 1-2-4-8-16. 
			Array.Reverse(array);
			/*
			 * [0] = 1
			 * [1] = 2
			 * [2] = 4
			 * etc
			 */
			int sum = 0;

			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == '1')
				{
					// Method uses raising 2 to the power of the index. 
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
			Console.WriteLine("decimal: " + Environment.NewLine + sum);
			Console.ReadKey();

			string answer;
			string result;
			Console.Write("Enter a Decimal number : ");
			answer = Console.ReadLine();

			int num = Convert.ToInt32(answer);
			result = "";
			while (num > 1)
			{
				int remainder = num % 2;
				result = Convert.ToString(remainder) + result;
				num /= 2;
			}
			result = Convert.ToString(num) + result;
			Console.WriteLine("Binary: {0}", result);
			Console.ReadKey();
		}
	}
}
