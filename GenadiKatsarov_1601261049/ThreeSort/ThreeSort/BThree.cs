using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeSort
{
    class BThree
    {
        public BNode root { get; set; }

        public BThree() { }
        public BThree(int value)
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
                if (insertion != null)
                {
                    this.root = insertion;
                    return node;
                }
                return null;
            }

            if (node.Value == value)
            {
                return node;
            }

            if (value < node.Value)
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
        public void InorderRec(BNode root)
        {

            if (root != null)
            {
                InorderRec(root.Left);
                Console.Write(root.Value + " | ");
                InorderRec(root.Right);
            }
        }
        public void Treeins(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Add(arr[i]);
            }

        }
    }
}
