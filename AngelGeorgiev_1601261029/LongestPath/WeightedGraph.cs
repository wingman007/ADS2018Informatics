using System.Collections.Generic;

namespace ShortestCycle {
    class WeightedGraph<T> {

        private List<Node<T>> nodes = new List<Node<T>>();
        private List<Connection<T>> connections = new List<Connection<T>>();
        private Dictionary<Node<T>, List<Connection<T>>> connectionMap = new Dictionary<Node<T>, List<Connection<T>>>();
        
        private List<Node<T>> curPath = new List<Node<T>>();
        private Node<T> end = null;
        private int minLen;

        public Node<T> AddNode(T value) {
            Node<T> newNode = new Node<T>(value, nodes.Count);
            nodes.Add(newNode);
            connectionMap.Add(newNode, new List<Connection<T>>());
            return newNode;
        }

        public void Connect(Node<T> node1, Node<T> node2, int weight) {
            Connection<T> connection = new Connection<T>(node1, node2, weight);

            connections.Add(connection);

            connectionMap[node1].Add(connection);
            connectionMap[node2].Add(connection);
        }

        public bool PathWithLengthExists(Node<T> start, Node<T> end, int minLen) {
            this.end = end;
            this.minLen = minLen;
            return SearchPath(start);
        }

        private bool SearchPath(Node<T> current) {
            if (current == end) {
                if (curPath.Count >= minLen) {
                    return true;
                }
                return false;
            }
            else {
                curPath.Add(current);

                foreach (var conn in connectionMap[current]) {
                    Node<T> other = conn.GetOther(current);
                    if (!curPath.Contains(other)) {
                        bool foundPath = SearchPath(other);
                        if (foundPath) {
                            curPath.Remove(current);
                            return true;
                        }
                    }
                }

                curPath.Remove(current);

                return false;
            }
        }
      
    }
}
