using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Bag", "Pen", "Pencil" };
            Console.WriteLine("Input the String");
            string InputString = Console.ReadLine();
            bool res = arr.AsQueryable().Contains(InputString);
            Console.WriteLine("String " + InputString + " is in the array? " + "\n" + res);
        }
    }
}
