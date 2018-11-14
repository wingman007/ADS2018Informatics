using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDecimal
{
    class Convertor
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number to convert: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Choose 1(Binary To Decimal), 2(Decimal To Binary) or 0(Exit): ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 0: return;
                case 1:
                    Console.WriteLine(BinaryToDec(number.ToString()));
                    break;
                case 2:
                    Console.WriteLine(DecToBinary(number));
                    break;
                default:
                    Console.WriteLine("Wrong choice!");
                    break;

            }
            Console.ReadLine();
        }

        static string DecToBinary(int number)
        {
            int remainder;
            string result = string.Empty;
            while (number > 0)
            {
                remainder = number % 2;
                number /= 2;
                result = remainder.ToString() + result;
            }
            return result;
        }

        static int BinaryToDec(string input)
        {

            char[] array = input.ToCharArray();
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
            return sum;
        }
    }
}
