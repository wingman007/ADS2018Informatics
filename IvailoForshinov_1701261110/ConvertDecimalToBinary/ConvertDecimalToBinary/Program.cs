using System;

namespace ConvertDecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Decimal Number: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Binary Number:  {0}", result);
        }
    }
}
