using System;
using System.Text;
using System.Collections.Generic;

namespace Polynoms
{
	class CalculateТheПolynomial
	{
		static void Main()
		{

			int[] polynom1 = EnterPolynom(), polynom2 = EnterPolynom();

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("First Polynom: " + PrintThisPolynom(polynom1));
			Console.WriteLine();
			Console.WriteLine("Second Polynom: " + PrintThisPolynom(polynom2));
			Console.WriteLine();
			Console.WriteLine();
			string temp = SubtractionPolynoms(polynom1, polynom2);
			SumPolynoms(polynom1, polynom2);
			Console.WriteLine();
			Console.WriteLine();
			temp = SubtractionPolynoms(polynom1, polynom2);
			Console.WriteLine("Subtraction of polynomials:");
			temp = SubtractionPolynoms(polynom1, polynom2);
			Console.WriteLine(temp);
			Console.WriteLine();
			Console.WriteLine();
			temp = SubtractionPolynoms(polynom1, polynom2);
			MultiplyPolynoms(polynom1, polynom2);
			Console.WriteLine();
			Console.WriteLine();




			Console.Write("Enter parameter x = ");
			int x = Convert.ToInt32(Console.ReadLine());
			CalculatePolynoms(polynom1, polynom2, x);



		}

		private static void MultiplyPolynoms(int[] p1, int[] p2)
		{
			int length = p1.Length + p2.Length;
			int[] multiplyed = new int[length];
			for (int i = 0; i < p1.Length; i++)
			{
				for (int j = 0; j < p2.Length; j++)
				{
					multiplyed[i + j] += p1[i] * p2[j];
				}
			}
			Console.WriteLine("Мultiplication of polynomials:");
			Console.WriteLine("({0}) * ({1}) = {2}", PrintThisPolynom(p1), PrintThisPolynom(p2), PrintThisPolynom(multiplyed));
		}

		static void SumPolynoms(int[] p1, int[] p2)
		{
			int[] p3 = p1.Length < p2.Length ? SumPolynomsWithDifferentLength(p1, p2) : SumPolynomsWithDifferentLength(p2, p1);
			Console.WriteLine("Sum of polynomials:");
			Console.WriteLine("({0}) + ({1}) = {2}", PrintThisPolynom(p1), PrintThisPolynom(p2), PrintThisPolynom(p3));
		}

		static string SubtractionPolynoms(int[] p1, int[] p2)
		{
			int[] p3 = p1.Length < p2.Length ? SubtractionPolynomsWithDifferentLength(p1, p2) : SubtractionPolynomsWithDifferentLength(p2, p1);

			return "(" + PrintThisPolynom(p1) + ")" + " - (" + (PrintThisPolynom(p2)) + ") = " + PrintThisPolynom(p3);
		}


		static StringBuilder PrintThisPolynom(int[] p)
		{
			StringBuilder output = new StringBuilder();
			bool first = true;
			List<int> list = new List<int>();

			for (int i = p.Length - 1; i >= 0; i--)
			{
				list.Add(p[i]);
			}

			for (int i = 0; i < p.Length; i++)
			{
				p[i] = list[i];
			}

			for (int i = p.Length - 1; i >= 0; i--)
			{
				if (p[i] != 0)
				{
					if (!first)
					{
						output.Append("+ ");
					}
					output.Append(p[i]);
					if (i == 1)
					{
						output.Append("x ");
					}
					if (i > 1)
					{
						output.Append("x^");
						output.Append(i);
						output.Append(" + ");

					}
					else if (i == 1)
						first = false;
				}
			}
			for (int i = p.Length - 1; i > 0; i--)
			{
				p[i] = list[i];
			}
			return output;
		}



		static int[] SumPolynomsWithDifferentLength(int[] shortP, int[] longP)
		{
			int[] p = new int[longP.Length];
			for (int i = 0; i < shortP.Length; i++)
			{
				p[i] = shortP[i] + longP[i];
			}
			for (int i = shortP.Length; i < longP.Length; i++)
			{
				p[i] = longP[i];
			}
			return p;
		}

		static int[] SubtractionPolynomsWithDifferentLength(int[] shortP, int[] longP)
		{
			int[] p = new int[longP.Length];
			for (int i = 0; i < shortP.Length; i++)
			{
				longP[i] = longP[i];
				p[i] = longP[i] - shortP[i];
			}
			for (int i = shortP.Length; i < longP.Length; i++)
			{
				p[i] = longP[i];
			}
			return p;
		}

		static void CalculatePolynoms(int[] p1, int[] p2, int x)
		{

			int sumFisrtPolynom = 0;
			int sumSecondPolynom = 0;

			for (int i = 0; i < p1.Length; i++)
			{
				//p1[i] *= -1;
				sumFisrtPolynom = sumFisrtPolynom + (int)Math.Pow(x, p1[i]);
			}

			for (int j = 0; j < p2.Length; j++)
			{
				sumSecondPolynom = sumSecondPolynom + (int)Math.Pow(x, p2[j]);
			}

			Console.WriteLine("Sum of the first polynomial with a x = " + x);
			Console.WriteLine(sumFisrtPolynom);
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Sum of the second polynomial with a x = " + x);
			Console.WriteLine(sumSecondPolynom);
			Console.WriteLine();
			Console.WriteLine();
		}



		static int[] EnterPolynom()
		{
			int[] polynomQuef;
			while (true)
			{
				try
				{
					Console.WriteLine("Enter a polynoms values:");
					string line = Console.ReadLine();
					string[] quef = line.Split(' ');
					polynomQuef = new int[quef.Length];
					for (int i = 0; i < quef.Length; i++)
					{
						polynomQuef[i] = int.Parse(quef[i]);
					}

					return polynomQuef;
				}
				catch (FormatException)
				{
					Console.WriteLine("Input isn't valid! Try again!");
				}
				catch (OverflowException)
				{
					Console.WriteLine("A queficent you entered is too big or too small! Try again!");
				}
			}
		}
	}
}
