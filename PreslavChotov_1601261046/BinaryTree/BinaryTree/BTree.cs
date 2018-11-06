using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<BNode> SearchInInterval(int intervalMin,int intervalMax)
        {
            List<BNode> list = new List<BNode>();
            SearchInInterval2(this.root,intervalMin,intervalMax,list);

            return list;
        }

        private void SearchInInterval2(BNode node,int IntervalMin, int IntervMax, List<BNode> list)
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
