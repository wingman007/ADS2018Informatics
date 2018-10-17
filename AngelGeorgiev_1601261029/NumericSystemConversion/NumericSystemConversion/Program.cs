using System;
using System.Text;
using System.Collections.Generic;

namespace Parser
{
    class Program
    {
        static string input;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Input a number to convert it to binary. Type Q to quit. ");

            do
            {
                Console.WriteLine("What number should we convert?");
                input = Console.ReadLine();

                string number = input;
                //number = number.Trim();

                Console.WriteLine("What system?");
                input = Console.ReadLine();

                int system = 0;
                if (int.TryParse(input, out system))
                {
                    if (Validate(number, system))
                    {
                        Console.WriteLine("The converted number is : " + ToDecimal(number, system));
                        continue;
                    }
                }
                Console.WriteLine("Invalid input!");
            } while (input != "q");
        }

        static bool Validate(string number, int systemBase)
        {
            for (int i = 0; i < number.Length; i++)
            {
                int cast;
                if (int.TryParse(number[i].ToString(), out cast))
                {
                    if (cast >= systemBase)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        static string ToDecimal(string number, int systemBase)
        {

            int result = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int element = int.Parse(number[number.Length - i - 1].ToString());

                for (int j = 0; j < i; j++)
                {
                    element *= systemBase;
                }
                result += element;
            }

            return result.ToString();
        }

        static string FromDecimal(int number, int systemBase)
        {
            List<char> result = new List<char>();

            do
            {
                result.Insert(0, (number % systemBase).ToString()[0]);
                number /= systemBase;

            } while (number != 0);

            return CollectionToString(result);
        }

        static string CollectionToString(IReadOnlyList<char> list)
        {
            StringBuilder text = new StringBuilder();
            foreach (char symbol in list)
            {
                text.Append(symbol);
            }

            return list.ToString();
        }
    }
}
