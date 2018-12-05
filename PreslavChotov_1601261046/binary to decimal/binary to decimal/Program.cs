using System;

namespace binary_to_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter decimal number:");

            string number = Console.ReadLine();

            int b = Convert.ToInt32(number, 2);

            Console.WriteLine("The decimal number is: " + b);
            Console.ReadLine();
            
          
        }
    }

}
