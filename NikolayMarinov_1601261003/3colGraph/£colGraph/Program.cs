using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _colGraph
{
    class Program
    {
        static int[,] A = new int[,] {{0,1,0,0,1},{1,0,1,1,1},{0,1,0,1,0},{0,1,1,0,1},{1,1,0,1,0}};
        const int n =5;
        static int[] col = new int[200];
        static int maxcol;
        static int count = 0;
        static int foundSol = 0;

        static void showSol()
        {
            int i;
            count++;
            Console.WriteLine("minimal graph coloring: \n");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("point "+ (i+1) +" with color "+ col[i] + " \n");
            }
        }
        static void nextCol(int i)
        {
            int k, j, success;
            if (i == n) { showSol(); return; }
            for (k = 1; k <= maxcol; k++)
            {
                col[i] = k;
                success = 1;
                for (j = 0; j < n; j++)

                    if (A[i,j] == 1 && col[j] == col[i])
                    {
                        success = 0;
                        break;
                    }
                    if (success == 1) nextCol(i + 1);

                    col[i] = 0;

            }
        }
        static void Main(string[] args)
        {
            int i;
            for (maxcol = 1; maxcol <= n; maxcol++)
            {
               // for (i = 0; i < n; i++) col[i] = 0;
                nextCol(0);
                if (count!=0) break;
            }
            Console.WriteLine("Total colorings found with " + maxcol + " colors: " + count);
            

        }
    }
}
