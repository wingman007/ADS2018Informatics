using System;

namespace NumberSystems
{
    class Program
    {
        static void Main(string[] args)
        {//convert a binary to a decimal
            int m1, m, p = 1;
            int de = 0, k = 1, j, d;
            Console.Write("Convert a binary to decimal\n\n");
            Console.Write("Enter a binary number");
            m = Convert.ToInt32(Console.ReadLine());
            m1 = m;
            for (j = m; j > 0; j = j / 10)
            {
                d = j % 10;
                if (k == 1)
                    p *= 1;
                else
                    p *= 2;
                de = de + (d * p);
                k++;
            }
            Console.Write("\n The binary number {0} \n The equivalent Decimal number {1}\n\n", m1, de);
            Console.ReadLine();

           
        }
    }
}
