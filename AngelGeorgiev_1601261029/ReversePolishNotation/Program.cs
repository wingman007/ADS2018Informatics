using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolishNotation {
    class Program {


        static void Main(string[] args) {

            ReverseNotationParser parser = new ReverseNotationParser();

            Console.WriteLine("Write an expression in Reverse Polish Notation and press enter. Use [Q] to quit.");

            string input = "";

            bool running = true;
            do {
                input = Console.ReadLine();
                input = input.Trim();

                if (input.ToLower() == "q") { 
                    running = false;
                    continue; 
                }

                try {
                    int result = parser.Parse(input);
                    Console.WriteLine(" = " + result);
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                }


            } while (running);
        }
    }
}
