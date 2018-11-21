using System;
using System.Collections.Generic;
using System.IO;

namespace NonCrossingRoutes
{
    public class DijkstraAlgorithm
    {
        private const int VerticesCount = 10;
        private const int StartVertex = 1;
        private const int NoParent = -1;
        private const int MaxValue = 1000000;

        private static readonly int[,] Graph = new int[VerticesCount, VerticesCount]
        {
            { 0, 23, 0, 0, 0, 0, 0, 8, 0, 0 },
            { 23, 0, 0, 3, 0, 0, 34, 0, 0, 0 },
            { 0, 0, 0, 6, 0, 0, 0, 25, 0, 7 },
            { 0, 3, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 10, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 10, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 3, 0 },
            { 7, 0, 25, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 23, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 30, 0, 23 }
        };

        private static readonly HashSet<int> T = new HashSet<int>();
        private static readonly int[] DijkstraDistances = new int[VerticesCount];
        private static readonly int[] Predecessors = new int[VerticesCount];

        internal static void Main()
        {
            Dijkstra(StartVertex - 1);
            PrintResult(StartVertex - 1);
        }

        // Dijkstra algorithm - minimal route from s to other edges
        private static void Dijkstra(int startVertex)
        {
            // Initialization: DijkstraDistances[i] = A[StartVertex, i], i∈V, i != StartVertex
            for (int i = 0; i < VerticesCount; i++)
            {
                if (Graph[startVertex, i] == 0)
                {
                    DijkstraDistances[i] = MaxValue;
                    Predecessors[i] = NoParent;
                }
                else
                {
                    DijkstraDistances[i] = Graph[startVertex, i];
                    Predecessors[i] = startVertex;
                }
            }

            for (int i = 0; i < VerticesCount; i++)
            {
                T.Add(i); // T holds all of the edges
            }

            T.Remove(startVertex); // from graph, excluding startVertex
            Predecessors[startVertex] = NoParent;

            while (T.Count > 0)
            {
                // Selects edge j from T, in which DijkstraDistances[j] is minimal
                int j = NoParent;
                int distanceToI = MaxValue;
                for (int i = 0; i < VerticesCount; i++)
                {
                    if (T.Contains(i) && DijkstraDistances[i] < distanceToI)
                    {
                        distanceToI = DijkstraDistances[i];
                        j = i;
                    }
                }

                if (j == NoParent)
                {
                    // DijkstraDistances[i] = MaxValue, for all i: exit
                    break;
                }

                T.Remove(j);

                // For each i to T executes DijkstraDistances[i] = 
                // min(DijkstraDistances[i], DijkstraDistances[j] + Graph[j, i])
                for (int i = 0; i < VerticesCount; i++)
                {
                    if (T.Contains(i) && Graph[j, i] != 0)
                    {
                        if (DijkstraDistances[i] > DijkstraDistances[j] + Graph[j, i])
                        {
                            DijkstraDistances[i] = DijkstraDistances[j] + Graph[j, i];
                            Predecessors[i] = j;
                        }
                    }
                }
            }
        }

        private static void PrintPath(int startVertex, int vertex)
        {
            if (Predecessors[vertex] != startVertex)
            {
                PrintPath(startVertex, Predecessors[vertex]);
            }

            Console.Write("{0} ", vertex + 1);
        }

        private static void PrintResult(int startVertex)
        {
            for (int i = 0; i < VerticesCount; i++)
            {
                if (i != startVertex)
                {
                    if (DijkstraDistances[i] == MaxValue)
                    {
                        Console.WriteLine("There is no path between edges {0} и {1}", startVertex + 1, i + 1);
                    }
                    else
                    {
                        Console.Write("Minimal non-crossing route between edges {0} до {1}: {0} ", startVertex + 1, i + 1);
                        PrintPath(startVertex, i);
                        Console.WriteLine(", route lenght: {0}", DijkstraDistances[i]);
                    }
                }
            }
        }
    }
}