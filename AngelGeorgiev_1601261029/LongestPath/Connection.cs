using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestCycle {
    class Connection<T> {

        private readonly Node<T> node1;
        private readonly Node<T> node2;
        private readonly int weight;

        public Node<T> Node1 { get { return node1; } }
        public Node<T> Node2 { get { return node2; } }
        public int Weight { get { return weight; } }

        public Connection(Node<T> node1, Node<T> node2, int weight) {
            this.node1 = node1;
            this.node2 = node2;
            this.weight = weight;
        }

        public Node<T> GetOther(Node<T> thisNode) {
            if (node1 == thisNode) { return node2; }
            else if (node2 == thisNode) { return node1; }
            return null;
        } 
    }
}
