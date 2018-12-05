using System;
public class Exercise21
{
    public static void Main()
    {
        int i, j, k, r1, c1, r2, c2, sum = 0;

        int[,] arr1 = new int[50, 50];
        int[,] brr1 = new int[50, 50];
        int[,] crr1 = new int[50, 50];

        Console.Write("\n\nУмножение на 2 матрици\n");
        Console.Write("----------------------------------\n");

        Console.Write("\nВъведете броя на редовете и колоните на първата матрица:\n");
        Console.Write("Редове : ");
        r1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Колони : ");
        c1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nВъведете броя на редовете и колоните на втората матрица :\n");
        Console.Write("Редове : ");
        r2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Колони : ");
        c2 = Convert.ToInt32(Console.ReadLine());

        if (c1 != r2)
        {
            Console.Write("Не е възможно умножението на матрици.");
            Console.Write("\nКолоната на първата матрица и реда на втората матрица трябва да бъдат еднакви.");
        }
        else
        {
            Console.Write("Входни елементи в първата матрица :\n");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    Console.Write("елемент - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("Входни елементи във втората матрица :\n");
            for (i = 0; i < r2; i++)
            {
                for (j = 0; j < c2; j++)
                {
                    Console.Write("елемент - [{0}],[{1}] : ", i, j);
                    brr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nПървата матрица е :\n");
            for (i = 0; i < r1; i++)
            {
                Console.Write("\n");
                for (j = 0; j < c1; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }

            Console.Write("\nВтората матрица е :\n");
            for (i = 0; i < r2; i++)
            {
                Console.Write("\n");
                for (j = 0; j < c2; j++)
                    Console.Write("{0}\t", brr1[i, j]);
            }
            //multiplication of matrix
            for (i = 0; i < r1; i++)
                for (j = 0; j < c2; j++)
                    crr1[i, j] = 0;
            for (i = 0; i < r1; i++)    //row of first matrix
            {
                for (j = 0; j < c2; j++)    //column of second matrix
                {
                    sum = 0;
                    for (k = 0; k < c1; k++)
                        sum = sum + arr1[i, k] * brr1[k, j];
                    crr1[i, j] = sum;
                }
            }
            Console.Write("\nУмножението на двете матрици е : \n");
            for (i = 0; i < r1; i++)
            {
                Console.Write("\n");
                for (j = 0; j < c2; j++)
                {
                    Console.Write("{0}\t", crr1[i, j]);
                }
            }
        }
        Console.Write("\n\n");
    }
}
