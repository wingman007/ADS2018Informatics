using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimaltobinaryandback
{
    class Program
    {
        static char input;
        private static int number;
        private static int number1;

        static void Main(string[] args)
        {
            Console.WriteLine("What algorithm you want to use ... ?");
            Console.WriteLine("1.Decimal to Binary");
            Console.WriteLine("2.Binary to Decimal");

            Console.WriteLine("Input your choice - ");
            string message = Console.ReadLine();
            input = message[0];

            do
            {
                if (input == '1')

                {
                    DecimalToBinary(number);
                    break;

                }

                if (input == '2')
                {

                    BinaryToNumber(number1);
                    break;
                }




            }
            while (input != '1' || input != '2');
            Console.ReadLine();
        }

        static void DecimalToBinary(int number)
        {
            Console.Write("Enter Decimal Number : ");
            int decimalNumber = int.Parse(Console.ReadLine());
            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;


            }


            Console.WriteLine("Binary : {0}", result);
            Console.ReadKey();
        }
        static void BinaryToNumber(int number1)
        {
            int result = 0, counter = 0, power, temp;
            Console.WriteLine("Please enter a binary number: ");
            int BinaryNumber = int.Parse(Console.ReadLine());
            while (BinaryNumber != 0)
            {
                power = 1;
                for (int i = 0; i < counter; i++) power = power * 2;

                temp = BinaryNumber % 10;
                result = result + (power * temp);
                BinaryNumber = BinaryNumber / 10;

                counter++;

            }
            Console.WriteLine("The Decimal value is : {0} ", result);
            Console.ReadKey();



        }
        static void NextStep(int next)
        {
            Console.WriteLine("Please enter 3 to continue: ");
            next = int.Parse(Console.ReadLine());



        }

    }
}


