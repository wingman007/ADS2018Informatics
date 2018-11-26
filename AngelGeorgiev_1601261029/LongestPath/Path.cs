using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestCycle {
    class Path<T> : IEnumerable<Node<T>> {
        private List<Node<T>> nodes = new List<Node<T>>();
        private List<Connection<T>> connections = new List<Connection<T>>();
        private int length = 0;

        public IReadOnlyList<Node<T>> Nodes { get { return nodes; } }
        public IReadOnlyList<Connection<T>> Connections { get { return connections; } }
        public int NumNodes { get { return nodes.Count; } }
        public int Length { get { return length; } }
        public bool Empty { get { return nodes.Count == 0; } }

        public Path() { }
 
        public Path(Node<T> start, Node<T> end) {

            if (start == end) {
                nodes.Add(start);
                return;
            }

            Node<T> current = end;

            while (current != start) {
                nodes.Add(current);
                connections.Add(current.Prev);
                length += current.Prev.Weight;
                current = current.PrevNode;
            }

            nodes.Add(start);
        }

        public void AddNode(Node<T> node) {
            nodes.Add(node);
        }

        public void AddConnection(Connection<T> conn) {
            connections.Add(conn);
        }

        public IEnumerator<Node<T>> GetEnumerator() {
            return nodes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return nodes.GetEnumerator();
        }
    }
}
