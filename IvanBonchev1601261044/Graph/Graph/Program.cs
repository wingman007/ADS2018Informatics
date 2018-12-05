namespace Graph
{
    using System;
    using System.Collections.Generic;

    public class Graph
    {
        private const int VerticesCount = 14;
        private const int StartVertex = 1;
        private const int EndVertex = 12;
        private const int K = 2;
        private static int ArrisCount = 0;

        private static readonly byte[,] Graph = new byte[VerticesCount, VerticesCount]
        {
            { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
            { 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0 },
            { 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1 },
            { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
            { 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0 }
        };

        private static readonly bool[] Used = new bool[VerticesCount];
        private static readonly int[] Predecessors = new int[VerticesCount];

        internal static void Main()
        {
            for (int i = 0; i < VerticesCount; i++)
            {
                Predecessors[i] = -1;
            }

            Bfs(StartVertex - 1);
            if (Predecessors[EndVertex - 1] > -1)
            {
                Console.WriteLine("Намереният път е:");
                Console.WriteLine("\nДължината на пътя е {0}.", PrintPath(EndVertex - 1));
                Console.WriteLine("\nНомера на ребрата е " + ArrisCount);
                if (K < ArrisCount) { Console.WriteLine("\nБроят ребра минава К."); }
                else Console.WriteLine("\nБроят ребра не минава К.");
            }
            else
            {
                Console.WriteLine("Не съществува път между двата върха!");
            }
            Console.ReadLine();
        }

        // Отпечатва върховете от минималния път и връща дължината му
        private static uint PrintPath(int vertex)
        {
            uint count = 1;
            if (Predecessors[vertex] > -1)
            {
                count += PrintPath(Predecessors[vertex]);
            }

            Console.Write("{0} ", vertex + 1);
            ArrisCount = Convert.ToInt32(count - 1);
            return count;
        }

        // Oбхождане в ширина от даден връх със запазване на предшественика
        private static void Bfs(int startVertex)
        {
            Queue<int> verticesQueue = new Queue<int>();
            verticesQueue.Enqueue(startVertex);
            Used[startVertex] = true;
            int levelVertex = 1;
            while (verticesQueue.Count > 0)
            {
                for (int i = 0; i < levelVertex; i++)
                {
                    int currentVertex = verticesQueue.Dequeue();
                    for (int j = 0; j < VerticesCount; j++)
                    {
                        if (Graph[currentVertex, j] == 1 && !Used[j])
                        {
                            verticesQueue.Enqueue(j);
                            Used[j] = true;
                            Predecessors[j] = currentVertex;
                            if (j == EndVertex)
                            {
                                return;
                            }
                        }
                    }
                }

                levelVertex = verticesQueue.Count;
            }
        }
    }
}