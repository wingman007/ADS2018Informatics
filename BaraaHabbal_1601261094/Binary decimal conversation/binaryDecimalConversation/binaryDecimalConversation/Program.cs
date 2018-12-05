using System;
using System.Text;
using System.Linq;

namespace binaryDecimalConversation
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("To convert from Decimal to Binary choose 1");
			Console.WriteLine("To convert from Binary to Decimal choose 2");

			var a = Convert.ToInt32(Console.ReadLine());
			string numberBase = a == 1 ? " binary " : "decimal";
			Console.WriteLine("Please enter a number");
			var num = Console.ReadLine();
			string ans = "";
			if (a == 1)
				ans = ToBinary(Convert.ToInt32(num));
			else if (a == 2)
				ans = ToDecimal(num).ToString();

			Console.WriteLine("Your number in " + numberBase + " = " +ans);
		}

		static string ToBinary(int num)
		{
			StringBuilder ans = new StringBuilder();
			while (num > 0)
			{
				ans.Append((num%2).ToString());
				num = num / 2;
			}

			return new string( ans.ToString().Reverse().ToArray());
		}

		static int ToDecimal(string num)
		{
			char[] arr = num.ToArray();
			int length = arr.Length - 1, ans = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i].Equals('1'))
					ans += (int)Math.Pow(2.0, length - i);
			}
			return ans;
		}
	}
}
