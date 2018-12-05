using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestCycle {
    class Program {
        static void Main(string[] args) {


            WeightedGraph<string> graph = new WeightedGraph<string>();

            Node<string> ivan = graph.AddNode("Ivan");
            Node<string> georgi = graph.AddNode("Georgi");
            Node<string> rosti = graph.AddNode("Rosti");
            Node<string> niki = graph.AddNode("Niki");
            Node<string> peter = graph.AddNode("Peter");
            Node<string> vasil = graph.AddNode("Vasil");

            graph.Connect(ivan, georgi, 4);
            graph.Connect(georgi, peter, 2);
            graph.Connect(niki, peter, 3);
            graph.Connect(niki, rosti, 8);
            graph.Connect(rosti, georgi, 1);
            graph.Connect(rosti, ivan, 2);
            graph.Connect(vasil, ivan, 1);
            graph.Connect(vasil, georgi, 1);

            Console.WriteLine();

            int minLength = 4;
            bool exists = graph.PathWithLengthExists(peter, vasil, minLength);
            Console.WriteLine("Path with length at least " + minLength + " : " + (exists ? "exists" : "does not exist"));
            
            Console.WriteLine();
        }
    }
}
