using System;

namespace SearchInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[3, 3];

            /* Stored values into the array*/
            Console.Write("Input elements in the matrix 3x3 :\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\nThe matrix is : \n");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 3; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.WriteLine("\n");

            Console.Write("Enter number for search in matrix: \n");

            int number = int.Parse(Console.ReadLine());

            for (int row = 0; row < arr1.GetLength(0); row++)
            {
                for (int col = 0; col < arr1.GetLength(1); col++)
                {
                    if (arr1[row, col] == number)
                    {
                        Console.WriteLine("Position is: [{0},{1}]", row, col);
                    }
                }
            }

            Console.Write("\n\n");
        }
    }
}
