using System;

namespace ExpressionRecovory
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Моля въведете израз: ");
            string backwords = Console.ReadLine();
           
            int length = backwords.Length;
            char[] normalString = new char[length];

            for (int i = length-1; i > -1; i--)
            {
                normalString[i] = backwords[i];
            }
              
            Console.Write("Нормализиран вид: ");
            for (int i = length - 1; i > -1; i--)
            {
                Console.Write(normalString[i]); 
            }
            Console.ReadLine();
        }
    }
}
