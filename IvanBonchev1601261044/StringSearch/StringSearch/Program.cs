using System;

namespace StringSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentences =
            {
                "Put the water over there.",
               "They're quite thirsty.",
               "Their water bottles broke.",
               "Don't read that sentence."
            };
            Console.WriteLine("Enter string to search:");
            string sPattern = Console.ReadLine() ;

            foreach (string s in sentences)
            {
                Console.Write($"{s,24}");

                if (System.Text.RegularExpressions.Regex.IsMatch(s, sPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    Console.WriteLine($"  (match for '{sPattern}' found)");
                }
                else
                {
                    Console.WriteLine($"  (match for '{sPattern}' not found)");
                }
            }
            Console.ReadLine();
        }
    }
}
