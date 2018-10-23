using System;
using System.Collections.Generic;
using System.Text;

namespace NumberSystems
{
    class Program
    {
        static string input;
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Въведете число от десетична бройна система: ");
                int decimalNumber = int.Parse(Console.ReadLine());

                int remainder;
                string result = string.Empty;
                while (decimalNumber > 0)
                {
                    remainder = decimalNumber % 2;
                    decimalNumber /= 2;
                    result = remainder.ToString() + result;
                }
                Console.WriteLine("В двоична бройна система числото е: "+ result);
            }
            while (input != "q");
        }
    }
}