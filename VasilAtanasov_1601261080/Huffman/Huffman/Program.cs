using System;
using System.Collections.Generic;
using System.Linq;


namespace Huffman
{
    class Node
    {
        public int frequency;
        public string data;
        public Node leftChild, rightChild;

        public Node(string data, int frequency)
        {
            this.data = data;
            this.frequency = frequency;
        }

        public Node(Node leftChild, Node rightChild)
        {
            this.leftChild = leftChild;
            this.rightChild = rightChild;

            this.data = leftChild.data + ":" + rightChild.data;
            this.frequency = leftChild.frequency + rightChild.frequency;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            IList<Node> list = new List<Node>();

            string[] characters = new string[] { "а", "б", "в", "г", "д", "е", "ж", "з", "и", "к", "л", "м" };
            int[] charfreq = new int[] { 51, 18, 53, 10, 55, 3, 50, 29, 20, 52, 54, 500 };

            for (int i = 0; i < characters.Length; i++)
            {
                int temp = 0;
                Int32.TryParse(characters[i], out temp);
                for (int j = 0; j < charfreq.Length; j++)
                {
                    list.Add(new Node("Character " + (i + 1) + " ", temp));
                    list.Add(new Node("Frequency " + (j + 1) + " ", charfreq[j]));
                }
            }

            Stack<Node> stack = GetSortedStack(list);

            while (stack.Count > 1)
            {
                Node leftChild = stack.Pop();
                Node rightChild = stack.Pop();

                Node parentNode = new Node(leftChild, rightChild);

                stack.Push(parentNode);

                stack = GetSortedStack(stack.ToList<Node>());
            }

            Node parentNode1 = stack.Pop();

            GenerateCode(parentNode1, "");

            DecodeData(parentNode1, parentNode1, 0, "0010011101001111");

            Console.ReadKey();
        }

        public static Stack<Node> GetSortedStack(IList<Node> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i].frequency > list[j].frequency)
                    {
                        Node tempNode = list[j];
                        list[j] = list[i];
                        list[i] = tempNode;
                    }
                }
            }

            Stack<Node> stack = new Stack<Node>();

            for (int j = 0; j < list.Count; j++)
                stack.Push(list[j]);

            return stack;
        }

        public static void GenerateCode(Node parentNode, string code)
        {
            if (parentNode != null)
            {
                GenerateCode(parentNode.leftChild, code + "0");

                if (parentNode.leftChild == null && parentNode.rightChild == null)
                    Console.WriteLine(parentNode.data + "{" + code + "}");

                GenerateCode(parentNode.rightChild, code + "1");
            }
        }

        public static void DecodeData(Node parentNode, Node currentNode, int pointer, string input)
        {
            if (input.Length == pointer)
            {
                if (currentNode.leftChild == null && currentNode.rightChild == null)
                {
                    Console.WriteLine(currentNode.data);
                }

                return;
            }
            else
            {
                if (currentNode.leftChild == null && currentNode.rightChild == null)
                {
                    Console.WriteLine(currentNode.data);
                    DecodeData(parentNode, parentNode, pointer, input);
                }
                else
                {
                    if (input.Substring(pointer, 1) == "0")
                    {
                        DecodeData(parentNode, currentNode.leftChild, ++pointer, input);
                    }
                    else
                    {
                        DecodeData(parentNode, currentNode.rightChild, ++pointer, input);
                    }
                }
            }
        }
    }
}
