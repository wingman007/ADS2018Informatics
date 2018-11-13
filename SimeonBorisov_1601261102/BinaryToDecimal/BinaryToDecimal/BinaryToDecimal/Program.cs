using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, binary_val, decimal_val = 0, base_val = 1, rem;
            Console.Write("Въведете двоично число (0-ли и 1-ци) : ");
            num = int.Parse(Console.ReadLine()); /* максимум 5 цифри */
            binary_val = num;
            while (num > 0)
            {
                rem = num % 10;
                decimal_val = decimal_val + rem * base_val;
                num = num / 10;
                base_val = base_val * 2;
            }
            Console.Write("Двоичното число е : " + binary_val);
            Console.Write("\nДесетичния еквивалент е : " + decimal_val);
            Console.ReadLine();
        }
    }
}