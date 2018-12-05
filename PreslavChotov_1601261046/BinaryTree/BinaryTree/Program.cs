using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BTree tree = new BTree(10);
            tree.Add(5);
            tree.Add(2);
            tree.Add(7);
            tree.Add(1);
            tree.Add(3);
            tree.Add(6);
            tree.Add(8);
            tree.Add(4);
            tree.Add(9);
            tree.Add(15);
            tree.Add(12);
            tree.Add(17);
            tree.Add(11);
            tree.Add(13);
            tree.Add(16);
            tree.Add(18);
            tree.Add(14);
            tree.Add(19);

           List<BNode> list= tree.SearchInInterval(5, 10);
            foreach (var item in list)
            {
                Console.WriteLine(item.Value);
            }
            Console.ReadLine();
        }
    }
}
