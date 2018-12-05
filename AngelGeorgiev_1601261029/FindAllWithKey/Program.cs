using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllWithKey {
    class Program {
        static void Main(string[] args) {

            SortedCollection<int, string> collection = new SortedCollection<int, string>();

            collection.AddElement(2, "Nikolay");
            collection.AddElement(2, "Rostislav");
            collection.AddElement(2, "Kostadin");
            collection.AddElement(4, "Ivan");
            collection.AddElement(4, "Georgi");
            collection.AddElement(2, "Nedqlko");
            collection.AddElement(3, "Denis");
            collection.AddElement(67, "Vasil");
            collection.AddElement(1, "Petar");
            collection.AddElement(4, "Mihail");
            collection.AddElement(112, "Jelqzko");
            collection.AddElement(4, "Kamen");

            Console.WriteLine("Collection Elements : ");
            collection.Print();

            Console.WriteLine();

            Console.WriteLine("Elements With Key 4 (Binary Search): ");
            foreach(var el in collection.BinarySearch(4)) {
                Console.WriteLine(el);
            }
            Console.WriteLine();

            Console.WriteLine("Elements With Key 4 (Sequential Search): ");
            foreach (var el in collection.SequentialSearch(4)) {
                Console.WriteLine(el);
            }
            Console.WriteLine();
        }
    }
}
