using System;
using System.Collections.Generic;
using System.Text;

namespace NumberSystems
{
    class Program
    {
        static string i;

        //starts both methods and enables a simple do while loop
        static void Main(string[] args)
        {
            do
            {
                BinaryToDecimal();
                DecimalToBinary();
                Console.WriteLine("Continue? (to stop type NO!)");
                i = Console.ReadLine();
            }
            while (i != "NO!");
        }

        //simple method for converting binary into decimal; has no input control; only positive numbers
        static void BinaryToDecimal()
        {
            {
                int n, bin_value, dec_value = 0, base_val = 1, rem;

                Console.Write("Enter a number (Binary (0 and 1)): ");

                n = int.Parse(Console.ReadLine());
                bin_value = n;

                while (n > 0)
                {
                    rem = n % 10;
                    dec_value = dec_value + rem * base_val;
                    n = n / 10;
                    base_val = base_val * 2;
                }
                Console.Write("Converted into decimal: " + dec_value + "\n");
            }
        }

        //simple method for converting decimal into binary; has no input control; only positive numbers
        static void DecimalToBinary()
        {
            string dec_number;
            string bin_number;

            Console.Write("Enter a number (Decimal): ");
            dec_number = Console.ReadLine();

            int num = Convert.ToInt32(dec_number);
            bin_number = "";
            while (num > 1)
            {
                int remainder = num % 2;
                bin_number = Convert.ToString(remainder) + bin_number;
                num /= 2;
            }
            bin_number = Convert.ToString(num) + bin_number;
            Console.WriteLine("Converted into binary: {0}", bin_number);
        }
    }
}