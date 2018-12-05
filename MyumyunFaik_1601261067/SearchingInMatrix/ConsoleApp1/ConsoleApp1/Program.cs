using System;

namespace SearchingInMatrix
{
    class Program
    {
        public static int row;
        public static int column;
        public static int[,] data;

        private static void Load(string rows, string columns)
        {
            try
            {
                row = Int32.Parse(rows);
                column = Int32.Parse(columns);

                Random rnd = new Random();
                data = new int[row, column];

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        data[i, j] = rnd.Next(0, 100);
                        Console.Write(data[i, j] + " - ");
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
                    for (int j = 0; j < column; j++)
                    {
                        if (Int32.Parse(number) == data[i, j])
                        {
                            Console.WriteLine("POSITION[" + i + " , " + j + "] ");
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
            Console.Write("Enter a Rows: ");
            string rows = Console.ReadLine();
            Console.Write("Enter a Column: ");
            string columns = Console.ReadLine();
            Load(rows, columns);

            Console.Write("Enter a Number: ");
            string number = Console.ReadLine();
            Search(number);
        }
    }
}