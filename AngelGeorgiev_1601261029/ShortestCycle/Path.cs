using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestCycle {
    class Path<T> : IEnumerable<Node<T>> {
        private List<Node<T>> nodes = new List<Node<T>>();
        private int length = 0;

        public IReadOnlyList<Node<T>> Nodes { get { return nodes; } }
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
                length += current.Prev.Weight;
                current = current.PrevNode;
            }

            nodes.Add(start);
        }

        public IEnumerator<Node<T>> GetEnumerator() {
            return nodes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return nodes.GetEnumerator();
        }
    }
}
