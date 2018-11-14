using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestCycle {
    class WeightedGraph<T> {

        private List<Node<T>> nodes = new List<Node<T>>();
        private List<Connection<T>> connections = new List<Connection<T>>();
        private Dictionary<Node<T>, List<Connection<T>>> connectionMap = new Dictionary<Node<T>, List<Connection<T>>>();
        private Connection<T> disabledConn = null;

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

        public Path<T> FindShortestCycle(int minNodes) {

            Path<T> shortest = null;
            int shortestLength = int.MaxValue;
            foreach (var conn in connections) {
                disabledConn = conn;

                var path = GetShortestPath(conn.Node1, conn.Node2);
                if (path != null && path.Nodes.Count >= minNodes && path.Length < shortestLength) {
                    shortestLength = path.Length;
                    shortest = path;
                }
            }
            disabledConn = null;

            return shortest;
        }

        public Path<T> GetShortestPath(Node<T> start, Node<T> end) {

            if (start == end) { return new Path<T>(start, end); }

            foreach (var node in nodes) {
                node.Prev = null;
            }

            bool[] traversed = new bool[nodes.Count];
            int[] distances = new int[nodes.Count];
            for (int i = 0; i < distances.Length; i++) {
                distances[i] = int.MaxValue;
            }

            distances[start.Index] = 0;
            traversed[start.Index] = true;

            Node<T> current = start;
            List<Connection<T>> connections = null;
            do {
                connections = connectionMap[current];
                traversed[current.Index] = true;

                int curDist = distances[nodes.IndexOf(current)];
                int shortestDist = int.MaxValue;
                Node<T> nearestNeigh = null;
                foreach (var conn in connections) {
                    if (conn == disabledConn) { continue; }

                    Node<T> neighbour = conn.GetOther(current);
                    int neighDist = distances[neighbour.Index];
                    
                    if (neighDist > curDist + conn.Weight) {
                        neighbour.Prev = conn;
                        distances[neighbour.Index] = curDist + conn.Weight;
                        neighDist = curDist + conn.Weight;
                    }

                    if (!traversed[neighbour.Index] && neighDist < shortestDist) {
                        shortestDist = neighDist;
                        nearestNeigh = neighbour;
                    }
                }

                current = nearestNeigh;
            } while (current != null);

            if (end.Prev == null) {
                return new Path<T>();   //Failed to find path
            }

            return new Path<T>(start, end);
        }
    }
}
