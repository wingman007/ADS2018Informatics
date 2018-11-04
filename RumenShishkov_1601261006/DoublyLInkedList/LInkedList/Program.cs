using System;

namespace LInkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var myNode = new DoublyLinkedList();
            myNode.AddToBeginning(7);
            myNode.AddToBeginning(9);
            myNode.AddToBeginning(10);
            myNode.DeleteLast();

            Console.WriteLine($"list empty={myNode.IsEmpty}");
            Console.WriteLine($"items count is {myNode.Count}");
            Console.WriteLine("list items:");
            Console.WriteLine(myNode);
        }
    }
}
