using System;

namespace SearchString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the string: ");
            string inputStr = Console.ReadLine();

            Console.WriteLine("Input the search string: ");
            string seatchString = Console.ReadLine();

            bool isFind = inputStr.Contains(seatchString);

            Console.WriteLine(isFind);
        }
    }
}