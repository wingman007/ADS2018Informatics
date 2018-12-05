using System;

namespace BinaryTreeTask
{
    class Program
    {

        static void Main(string[] args)
        {
           // TraverseKLD();
           // BinaryTree();

            var tree = new BinaryTreeNode { Value = 2 };
            var leftChild = new BinaryTreeNode { Value = 7 };
            var rightChild = new BinaryTreeNode { Value = 5 };

            tree.Left = leftChild;
            tree.Right = rightChild;

            rightChild.Right = new BinaryTreeNode { Value = 9 };
            rightChild.Right.Left = new BinaryTreeNode { Value = 4 };

            leftChild.Left.Left = new BinaryTreeNode { Value = 2 };
            leftChild.Left.Right = new BinaryTreeNode { Value = 6 };
            leftChild.Left.Right.Left = new BinaryTreeNode { Value = 5 };
            leftChild.Left.Right.Right = new BinaryTreeNode { Value = 11 };

    /*        TraverseKLD(BinaryTree)
        {
                Console.WriteLine(Value);
                if (leftChild)
                {
                    TraverseKLD(BinaryTree.leftchild);
                }

                if (rightchild)
                {
                    TraverseKLD(BinaryTree.rightchild);
                }
            }
    */

        }

        public class BinaryTreeNode
        {
            public int Value { get; set; }

            public BinaryTreeNode Left { get; set; }

            public BinaryTreeNode Right { get; set; }

        }
    }
}


