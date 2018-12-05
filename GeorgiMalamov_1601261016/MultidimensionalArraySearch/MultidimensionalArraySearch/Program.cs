using System;

namespace MultidimensionalArraySearch
{
    class Program
    {
        static void Main(string[] args)
        {
         

            int[,] mainArr = new int[4, 4] { { returnRandomValue(), returnRandomValue(), returnRandomValue(), returnRandomValue()},
                { returnRandomValue(), returnRandomValue(), returnRandomValue(), returnRandomValue()},
                { returnRandomValue(), returnRandomValue(), returnRandomValue(), returnRandomValue()},
                { returnRandomValue(), returnRandomValue(), returnRandomValue(), returnRandomValue()}
            };

            Console.WriteLine("The generated array is:");
            printArr(mainArr);

            int row, num;
            string inputString;

            Console.Write("Enter the row you wish to search(0-3): ");
            inputString = Console.ReadLine();
            row = Convert.ToInt32(inputString);
            Console.Write("Enter the array index you want(0-3): ");
            inputString = Console.ReadLine();
            num = Convert.ToInt32(inputString);
            Console.WriteLine();
            Console.WriteLine("The value is: {0}", mainArr[row, num]);

        }

        static int returnRandomValue()
        {

            Random rnd = new Random();
            int num = rnd.Next(100);// from 0 to 99

            return num;
        }

        static void printArr(int[,] arr) {

            int rowLength = arr.GetLength(0);
            int colLength = arr.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", arr[i, j]));
                }
                Console.WriteLine();
                //Console.Write(Environment.NewLine + Environment.NewLine);
            }

        }


    }
}
