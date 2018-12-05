using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class List {

        public bool IsEmpty;
        private node First;
        private node Last;

        public List() {

            First = null;
            IsEmpty = true;

        }

        public node getLast() {
            return Last;
        }

        private node FindLast() {
            node temp;
            temp = First;

            while (temp.next != null) {
                temp = temp.next;
            }
            return temp;
        }

        public node insert(int data) {

            node nodeLocal = new node(data);
            nodeLocal.next = First;

            if (First != null) {
                First.prev = nodeLocal;
            }
            First = nodeLocal;
            Last = FindLast();
            return nodeLocal;


        }

        public void DeleteNode(node node)
        {

            if (node != null)
            {
                if (node.next != null)
                {
                    node.next.prev = node.prev;
                }
                if (node.prev != null)
                {
                    node.prev.next = node.next;
                }
            }
        }

        public void DeleteFirst() {

            node temp = First;

            if (First != null) {

                First = First.next;
                if (First != null)
                    First.prev = null;
          
            }
        }

        public void TraverseWholeList() {

            node current = First;
            Console.WriteLine("\n\nWhole List: ");

            while (current!=  null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void TraverseForeward(node node) {

            if (node == null) { node = First; }

            Console.WriteLine("\n\nTraversing Foreward from: " + node.data);

            while (node != null)
            {

                Console.WriteLine(node.data);
                node = node.next;

            }
        }

        public void TraverseBackward(node node) {

            if (node == null) { node = First; }

            Console.WriteLine("\n\nTraversing backward from: "+node.data);

            while (node != null) {

                Console.WriteLine(node.data);
                node=node.prev;

            }
        }

        public void InsertBefore(node node, int data) {

            if (node == null) { return; }
            node newNode = new node(data);
            newNode.prev = node;
            if (node.next != null)
            {
                node.next.prev = newNode;
            }
            newNode.next = node.next;
            node.next = newNode;
        }


    }
    class node {

        public int data;
        public node next;
        public node prev;

        public node() {
            data = 0;
            next = null;
            prev = null;
        }

        public node(int data)
        {
            this.data = data;
            this.next = null;
            this.prev = null;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            List List = new List();

            List.insert(1);
            List.insert(2);

            node node4 = List.insert(4);

            List.insert(5);
            List.insert(6);
            List.insert(7);
            List.insert(8);

            node node9 = List.insert(9);

            List.insert(10);

            List.InsertBefore(node4, 3);

            List.TraverseWholeList();
            List.TraverseForeward(node4);
            List.TraverseBackward(node4);

            Console.WriteLine("\n\nAfter Deleting node 4 and node 9");
            
            List.DeleteNode(node4);
            List.DeleteNode(node9);
            List.TraverseWholeList();


        }
    }
}
