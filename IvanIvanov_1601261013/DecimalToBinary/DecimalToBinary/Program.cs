using System;

namespace DecimalToBinary
{
	class Program
	{
		static void Main(string[] args)
		{
			string number;
			bool isNum = false;
			int num;

			do
			{
				Console.WriteLine("Въведете десетично число");
				number = Console.ReadLine();

				isNum = int.TryParse(number, out num);
			} while (!isNum);

			int temp = 0;
			string binary = "";

			do
			{
				temp = num % 2;
				binary = temp + binary;
				num /= 2;
			} while (num > 0);

			Console.WriteLine(binary);
		}
	}
}
