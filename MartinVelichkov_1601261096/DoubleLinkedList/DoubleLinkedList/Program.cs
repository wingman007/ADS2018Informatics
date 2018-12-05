using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DLinkedList node1 = new DLinkedList(1);

            DLinkedList node3 = node1.InsertNext(3);

            DLinkedList node2 = node3.InsertPrev(2);

            DLinkedList node5 = node3.InsertNext(5);

            DLinkedList node4 = node5.InsertPrev(4);

            node1.TraverseFront();
            node5.TraverseBack();
        }
    }
}
