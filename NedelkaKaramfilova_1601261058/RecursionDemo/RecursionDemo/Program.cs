using System;

namespace RecursionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNum, pwrNum;
            int result;
            Console.Write("\n\n Рекурсия - степенуване на реално число. \n");
            Console.Write("------------------------------------------------\n");

            Console.Write(" Въведете число: ");
            baseNum = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Въведете степента: ");
            pwrNum = Convert.ToInt32(Console.ReadLine());

            result = CalcuOfPower(baseNum, pwrNum); //викане на функцията, съдържаща рекурсията

            Console.Write(" Стойността на {0} след степенуване на {1} е: {2} \n\n", baseNum, pwrNum, result);
        }

        public static int CalcuOfPower(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return x * CalcuOfPower(x, y - 1);
        }
    }
}