using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BNode
    {
        public int Value { get; set; }
        public BNode Left { get; set; }
        public BNode Right { get; set; }

        public BNode(int value)
        {


            this.Value = value;
        }
    }
}
namespace BinaryTree
{
    class BTree
    {
        public BNode root { get; set; }

        public BTree(int value)
        {
            this.root = new BNode(value);
        }
        public void Add(int value)
        {
            SearchHelper(this.root, value, new BNode(value));
        }
        private BNode SearchHelper(BNode node, int value, BNode insertion = null)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Value == value)
            {
                return node;
            }

            if (value > node.Value)
            {
                if (insertion != null && node.Right == null)
                {
                    node.Right = insertion;
                    return node;
                }

                return SearchHelper(node.Right, value, insertion);
            }

            if (insertion != null && node.Left == null)
            {
                node.Left = insertion;
                return node;
            }

            return SearchHelper(node.Left, value, insertion);
        }
        public List<BNode> SearchInInterval(int intervalMin, int intervalMax)
        {
            List<BNode> list = new List<BNode>();
            SearchInInterval2(this.root, intervalMin, intervalMax, list);

            return list;
        }

        private void SearchInInterval2(BNode node, int IntervalMin, int IntervMax, List<BNode> list)
        {
            if (node.Value >= IntervalMin && node.Value <= IntervMax)
            {
                list.Add(node);
            }
            if (node.Left != null)
            {
                SearchInInterval2(node.Left, IntervalMin, IntervMax, list);
            }
            if (node.Right != null)
            {
                SearchInInterval2(node.Right, IntervalMin, IntervMax, list);
            }
        }
    }
}
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

            List<BNode> list = tree.SearchInInterval(5, 10);
            foreach (var item in list)
            {
                Console.WriteLine(item.Value);
            }
            Console.ReadLine();
        }
    }
}