using System;

namespace MarcinHoppe.EightQueens
{
    class Program
    {
        static void Main(string[] args)
        {
            var problem = new EightQueensProblem();
            problem.Solve();
            problem.PrintSolution();
        }
    }
}