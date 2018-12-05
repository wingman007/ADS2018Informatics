using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int num;
            num = int.Parse(Console.ReadLine());
            int quotient;
            string remainder = "";
            while (num >= 1)
            {
                quotient = num / 2;
                remainder += (num % 2).ToString();
                num = quotient;
            }
            string binary = "";
            for (int i = remainder.Length - 1; i >= 0; i--)
            {
                binary = binary + remainder[i];
            }
            Console.WriteLine("The Binary format for given number is {0}", binary);
        }
    }
}
