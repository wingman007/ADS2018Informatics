using System;

namespace MatrixDoubleSort
{
    class Program
    {
        // Print function
        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]+" ");
                }
                Console.WriteLine();
            }
        }



        public static Random rnd = new Random(); 

        static void Main(string[] args)
        {
            
            int[,] matrix = new int[6, 6];  //Create matrix 6x6

            //Fill matrix with random numbers
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col]= rnd.Next(1, 100);

                }
            }
            Console.WriteLine("This is not sorted matrix:");
            PrintMatrix(matrix);
            Console.WriteLine();
            Console.WriteLine();

            //Sort numbers by rows
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int write = 0; write < matrix.GetLength(1); write++)
                {
                    for (int sort = 0; sort < matrix.GetLength(1) - 1; sort++)
                    {
                        if (matrix[row,sort] > matrix[row,sort + 1])
                        {
                           int  temp = matrix[row,sort + 1];
                            matrix[row,sort + 1] = matrix[row,sort];
                            matrix[row,sort] = temp;
                        }
                    }
                }
            }

            Console.WriteLine("This matrix is sorted by rows:");
            PrintMatrix(matrix);
            Console.WriteLine();
            Console.WriteLine();

            //Sort numbers by cols
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int write = 0; write < matrix.GetLength(0); write++)
                {
                    for (int sort = 0; sort < matrix.GetLength(0) - 1; sort++)
                    {
                        if (matrix[sort,col] > matrix[sort + 1,col])
                        {
                            int temp = matrix[sort + 1,col];
                            matrix[sort + 1,col] = matrix[sort,col];
                            matrix[sort,col] = temp;
                        }
                    }
                }
            }

            Console.WriteLine("This matrix is sorted by rows and cols:");
            PrintMatrix(matrix);
            Console.ReadLine();
        }
    }
}
