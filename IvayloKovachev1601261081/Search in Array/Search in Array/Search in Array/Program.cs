using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_in_Array
{
    class Program
    {
        static string input;
        static void Main(string[] args)
        {
            do
            {


                string[] names = { "Bob", "Ted", "Tom", "Fred", "Cool", };
                int[] personAge = { 77, 55, 78, 99, 100 };

                Console.WriteLine("Enter students name to search for");
                string personName = Console.ReadLine();

                bool contains = false;
                int personNumbers = 0;
                for (int i = 0; i < names.Length; i++)
                {
                    if (personName == names[i])
                    {
                        contains = true;
                        personNumbers = personAge[i];
                        break;
                    }
                }
                if (contains == true)
                {
                    Console.WriteLine("The name " + personName + " is found ");
                    Console.WriteLine("The person age is {0}", personNumbers);

                }
                else
                {
                    Console.WriteLine("The student is NOT is the class");

                }
                Console.WriteLine("To stop type stop");
                input = Console.ReadLine();

            }
            while (input != "stop");
        }
       
    }
}
