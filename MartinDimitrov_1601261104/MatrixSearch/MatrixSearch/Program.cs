using System;

namespace MatrixSearch
{
    class Program
    {
        public static int row;
        public static int col;
        public static int[,] matrix;
        static string input;

        private static void Load(string rows, string columns)
        {
            try
            {
                row = Int32.Parse(rows);
                col = Int32.Parse(columns);

                Random rnd = new Random();
                matrix = new int[row, col];

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        matrix[i, j] = rnd.Next(0, 100);
                        Console.Write(String.Format("{0}\t", matrix[i, j]));
                    }
                    Console.WriteLine(" ");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong!");
            }
        }

        private static void Search(string number)
        {
            try
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (Int32.Parse(number) == matrix[i, j])
                        {
                            Console.WriteLine("Element {0} found at location ({1}) ({2})\n", number, i + 1, j + 1);
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong!");
            }
        }

        public static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter number of rows: ");
                string rows = Console.ReadLine();
                Console.Write("Enter number of columns: ");
                string columns = Console.ReadLine();
                Console.WriteLine(" ");
                Load(rows, columns);
                Console.WriteLine(" ");
                Console.Write("Enter search number: ");
                string number = Console.ReadLine();
                Search(number);
                Console.WriteLine("Create a new random 2d array and continue? (to stop type NO!)");
                input = Console.ReadLine();

            }
            while (input != "NO!");
        }
    }
}