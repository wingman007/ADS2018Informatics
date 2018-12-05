using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your binary number ()1s or 0s only: ");
            string binary = Console.ReadLine();
            int dec = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[binary.Length - i - 1] == '0')
                {
                    continue;
                }

                dec += (int)Math.Pow(2, i);
            }

            Console.WriteLine(dec);
           
        }
    }
}
