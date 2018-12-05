using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolishNotation
{
    class ReverseNotationParser
    {
        private Stack<int> operandStack = new Stack<int>();
        private static readonly HashSet<string> binaryOperators = new HashSet<string>() { "-", "+", "*", "/" };

        public int Parse(string expression)
        {
            string[] symbols = expression.Split(null);

            for (int i = 0; i < symbols.Length; i++)
            {
                string symbol = symbols[i];

                if (binaryOperators.Contains(symbol))
                {
                    if (operandStack.Count < 2)
                    {
                        throw new ArgumentException("Невалиден израз!");
                    }

                    int lhs = operandStack.Pop();
                    int rhs = operandStack.Pop();


                    operandStack.Push(BinaryOperator(symbol, lhs, rhs));
                }
                else
                {
                    int operand = int.Parse(symbol);
                    operandStack.Push(operand);
                }
            }

            if (operandStack.Count != 1)
            {
                throw new ArgumentException("Невалиден израз!");
            }

            return operandStack.Pop();
        }

        private int BinaryOperator(string op, int lhs, int rhs)
        {
            switch (op)
            {
                case "-":
                    return lhs - rhs;
                case "+":
                    return lhs + rhs;
                case "*":
                    return lhs * rhs;
                case "/":
                    return lhs / rhs;
            }
            throw new ArgumentException("Invalid Operator : " + op);
        }

    }
}
