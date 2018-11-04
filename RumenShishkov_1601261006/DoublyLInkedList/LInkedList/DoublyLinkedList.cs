using System.Text;

namespace LInkedList
{
    public class Node
    {
        public int data;
        public Node prevItem, nextItem;

        public Node(int data)
        {
            this.data = data;
            this.nextItem = null;
        }
        public override string ToString()
        {
            return data.ToString();
        }
    }
    public class DoublyLinkedList
    {
        private Node headNode;
        public int Count { get; private set; }

        public bool IsEmpty => headNode == null;

        public DoublyLinkedList()
        {
            headNode = null;
        }

        public Node AddToBeginning(int data)
        {
            var tempNode = new Node(data)
            {
                nextItem = headNode
            };
            if (headNode != null)
            {
                headNode.prevItem = tempNode;
            }
            headNode = tempNode;
            Count++;
            return tempNode;
        }

        public Node DeleteLast()
        {
            Node temp = headNode;
            if (headNode != null)
            {
                headNode = headNode.nextItem;
                if (headNode != null)
                {
                    headNode.prevItem = null;
                }
            }
            Count--;
            return temp;
        }

        public override string ToString()
        {
            Node currentNode = headNode;
            StringBuilder builder = new StringBuilder();
            while (currentNode != null)
            {
                builder.Append($"|{currentNode}|");
                currentNode = currentNode.nextItem;
            }
            return builder.ToString();
        }

    }
}
