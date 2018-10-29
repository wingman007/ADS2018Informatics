using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int currNumber = number;
            int result;
            List<int> numbers = new List<int>();

            do
            {
                result = currNumber % 2;
                currNumber = currNumber / 2;
                numbers.Add(result);

            } while (currNumber != 0);

            Console.Write("RESULT: ");

            numbers.Reverse();

            foreach (var item in numbers)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
