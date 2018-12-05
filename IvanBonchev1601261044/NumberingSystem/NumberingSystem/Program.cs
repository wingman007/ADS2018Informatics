using System;
using System.Collections.Generic;

namespace NumberingSystem
{
    class Program
    {
        static char input;

        static void Main(string[] args)
        {

            Console.WriteLine("What system you want to convert ...");
            Console.WriteLine("1.Decimal to Binary");
            Console.WriteLine("2.Binary to Decimal");
            Console.WriteLine("Input your choice-");
            string message = Console.ReadLine();
            input = message[0];

            do { 
                if (input == '1')
                {
                Console.WriteLine("Enter decimal number:");
                int number = Convert.ToInt32(Console.ReadLine());
                ToBinary(number);
                    break;
                }

                if (input == '2')
                {
                    Console.WriteLine("Enter binary number:");
                    string number1 = Console.ReadLine();
                    ToDecimal(number1);
                    break;
                }


                }
            while (input!='1'||input!='2');
            Console.ReadLine();
        }


        static void ToBinary(int number)
        {
            int a = number;

            int[] b = new int[50];

            int i = 0;
            do
            {
                int c = a % 2;
                b[i] = c;
                a = a / 2;
                i++;
            }
            while (a > 0);

            Console.WriteLine("\n");
            for (int k = b.Length-1; k>=0; k--)
            {
                if (b[k] == 1)
                {
                    Console.WriteLine("The binary code of "+number+" is ");
                    for (int j = k; j >= 0; j--)
                    {
                        Console.Write(b[j]);
                    }
                    break;
                }
                    

            }
        }
        static void ToDecimal(string number)
        {
            double sum = 0;
            for (int i = 0; i <= number.Length - 1; i++)
            {
                double o = Convert.ToDouble(i);
                if (number[i] == '1')
                {
                    sum =sum + (Math.Pow(2,o));
                }
            }
            Console.WriteLine("The decimal code of " + number + " is ");
            Console.Write(sum);
        }

        
    }
}
