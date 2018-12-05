using System;
using System.Collections;

class Program
{

    /*
     * 
     * Prefix - example :  5-(6*7) converts to -5*67 (aka polish notation)
     * Infix - example : 5-(6*7) converts to 5-(6*7) default
     * Postfix - example :  5-(6*7) converts to 567*- (aka reverse polish notation)
     * 
     * credit for converter:
     * https://github.com/yazdipour/Infix-Prefix-Postfix-Converter
     */

    public static void Main()
    {
        string problem = "";
        Console.WriteLine("Welcome enter a Postfix problem or press Q to quit!");


        do
        {
            Console.WriteLine("\n-----------------------\n Enter :");
            // get the user input
            problem = Console.ReadLine().ToString();

            if (problem == "q")
            {
                Console.WriteLine("Quiting program!");
            }
            else
            {
                ConvertPostfixToInfix(problem);
            }



        } while (problem != "q");

    }
    private static bool isOperator(char symbol)
    {
        switch (symbol)
        {
            case '+':
            case '-':
            case '*':
            case '/':
            case '^':
            case '(':
            case ')':
            case '%':
                return true;
        }
        return false;
    }

    public static void ConvertPostfixToInfix(string str = "")
    {

        string result = "", right = "", left = "";
        Stack myStack = new Stack(str.Length);


        for (var pivot = 0; pivot < str.Length; pivot++)
        {
            if (isOperator(str[pivot]))
            {
                right = myStack.Pop().ToString();
                left = myStack.Pop().ToString();
                myStack.Push("(" + left + str[pivot] + right + ")");
            }
            else if (str[pivot] == ',')
            {
                var newstr = "";
                var ch = ' ';
                while (true)
                {
                    if (pivot < str.Length)
                        pivot++;
                    ch = str[pivot];
                    if (ch == ',')
                        break;
                    newstr += ch;
                }
                myStack.Push(newstr);
            }
            else if (str[pivot] != ' ')
            {
                myStack.Push(str[pivot].ToString());
            }
        }
        result += myStack.Pop();
        Console.WriteLine("the result is: " + result);

    }


}

