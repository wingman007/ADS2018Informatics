using System;

namespace binToDes
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInp;
            Console.WriteLine("Hello! Input 1 to convert to binary or 2 to convert to decimal. Type q to quit. ");

            do
            {
                Console.Write("Enter command: ");
                userInp = Console.ReadLine();

                int command = 0;
                int.TryParse(userInp, out command);

                switch (command)
                {

                    case 1:
                        BinToDec();
                        break;

                    case 2:
                        DeclToBin();
                        break;

                    default:

                        Console.WriteLine("quting program!");
                        break;
                }



            } while (userInp != "q");
        }

        static void BinToDec()
        {

            int number, input, output = 0, base_val = 1;

            Console.Write("Please enter a Binary number: ");

            number = int.Parse(Console.ReadLine());
            input = number;

            while (number > 0)
            {
                output = output + (number % 10) * base_val;
                number = number / 10;
                base_val *=2;
            }
            Console.WriteLine("Output Decimal: {0}, input: {1}", output,input);
            Console.WriteLine();
        }

        static void DeclToBin()
        {

            string input;
            string result = "";

            Console.WriteLine("Please enter a Decimal number:");
            input = Console.ReadLine();

            int number = Convert.ToInt32(input);

            while (number > 1)
            {
                int remainder = number % 2;
                result = Convert.ToString(remainder) + result;
                number /= 2;
            }
            result = Convert.ToString(number) + result;
            Console.WriteLine("Output Binary: {0} , Inputed: {1}", result, input);
            Console.WriteLine();
        }


    }
}
