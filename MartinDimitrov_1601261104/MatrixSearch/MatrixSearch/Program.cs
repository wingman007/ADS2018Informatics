using System;
using System.Text;

namespace MatrixSearch
{
    class Program
    {
        //saddleback search
        static bool search(int[,] matrix, int row,
                    int col, int x)
        {
            /* 
             set indexes for 
             bottom left element 
             */
            int i = row - 1, j = 0;
            while (i >= 0 && j < col)
            {
                if (matrix[i, j] == x)
                    return true;
                if (matrix[i, j] > x)
                    i--;
                else // if matrix[i][j] < x 
                    j++;
            }
            return false;
        }
        static string input;
        public static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5] //you change change 2d array size and input from here(if you do so you'll have to change numbers on line 50)
                {
                    {1,2,3,4,5 },
                    {6,7,8,9,10 },
                    {11,12,13,14,15 },
                    {16,17,18,19,20 },
                    {21,22,23,24,25 }
                };
            Console.WriteLine("------------------------------------");
            var rowCount = matrix.GetLength(0);
            var colCount = matrix.GetLength(1);
            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < colCount; col++)
                    Console.Write(String.Format("{0}\t", matrix[row, col]));
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------");

            do
             { 
             Console.Write("Enter Search element: ");
             string s = Console.ReadLine();
             int x = Int32.Parse(s);
                if (search(matrix, 5, 5, x))
                {
                    Console.Write("Element found \n");
                    Console.Write("Continue? (to stop type NO!)");
                    input = Console.ReadLine();
                }
                else
                {
                    Console.Write("Not found \n");
                    Console.Write("Continue? (to stop type NO!)");
                    input = Console.ReadLine();
                }
             }
             while (input != "NO!");
        }
    }
}
