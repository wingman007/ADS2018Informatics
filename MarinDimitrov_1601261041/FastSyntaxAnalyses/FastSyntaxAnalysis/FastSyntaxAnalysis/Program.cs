using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastSyntaxAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var stack = new Stack<char>();
            bool balanced = true;

            foreach (var some in input)
            {
                switch (some)
                {
                    case '(':  case '{':  case '[':  case '/':  case '*':
                        stack.Push(some);
                        break;

                    case ')':
                        if (!stack.Any() || stack.Pop() != '(')
                        {
                           balanced = false;
                        }
                        break;

                    case '}':
                        if (!stack.Any() || stack.Pop() != '{')
                        {
                           balanced = false;
                        }
                        break;

                    case ']':
                        if (!stack.Any() || stack.Pop() != '[')
                        {
                            balanced = false;
                        }
                        break;

                    case '/':
                        if (!stack.Any() || stack.Pop() != '/')
                        {
                            balanced = false;
                        }
                        break;

                    case '*':
                        if (!stack.Any() || stack.Pop() != '*')
                        {
                            balanced = false;
                        }
                        break;
                }
            }

            var end = balanced ? "YES" : "NO";
            Console.WriteLine(end);
        }
    }
}

        
    

