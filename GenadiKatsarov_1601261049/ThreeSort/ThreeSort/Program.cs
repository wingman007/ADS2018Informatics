using System;

namespace ThreeSort
{
    class Program
    {

        static void Main(string[] args)
        {
            BThree tree = new BThree();
            int[] arr = { 129, 56, 7, 1, 14 };
            tree.Treeins(arr);
            tree.InorderRec(tree.root);

            Console.ReadLine();

            Console.WriteLine();
        }
    }
}
