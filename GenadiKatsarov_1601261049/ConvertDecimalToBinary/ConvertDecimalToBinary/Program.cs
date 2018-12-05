using System;

namespace ConvertDecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter decimal number:");

            int value = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(value, 2);

            Console.WriteLine("The binary number is:"+binary);
            Console.ReadLine();
        }
    }
}
