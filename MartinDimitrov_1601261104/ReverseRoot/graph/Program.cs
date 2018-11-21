using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph
{
    //Directed graph- Adjacency list representation
    class directedGraph
    {
        //total no of vertices
        private int Vertices;
        //adjency list array for all vertices.
        private List<Int32>[] adj;
        /* Example : vertices=5
         *      0->[1,2]
         *      1->[2]
         *      2->[0,3]
         *      3->[5]
	     *	    4->[9,7]
         */

        //constructor
        public directedGraph(int v)
        {
            Vertices = v;
            adj = new List<Int32>[v];
            //Instantiate adjacecny list for all vertices
            for (int i = 0; i < v; i++)
            {
                adj[i] = new List<Int32>();
            }

        }

        //Add edge from v->w
        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
        }

        //DFS traversal 
        // DFS uses stack as a base.
        public void DFS(int s)
        {
            bool[] visited = new bool[Vertices];

            //For DFS use stack
            Stack<int> stack = new Stack<int>();
            visited[s] = true;
            stack.Push(s);

            while (stack.Count != 0)
            {
                s = stack.Pop();
                Console.WriteLine("next->" + s);
                foreach (int i in adj[s])
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        stack.Push(i);
                    }
                }
            }
        }

        public void PrintAdjacecnyMatrix()
        {
            for (int i = 0; i < Vertices; i++)
            {
                Console.Write(i + ":[");
                string s = "";
                foreach (var k in adj[i])
                {
                    s = s + (k + ",");
                }
                s = s.Substring(0, s.Length - 1);
                s = s + "]";
                Console.Write(s);
                Console.WriteLine();
            }
        }
        //Calling methods
        public static void Main()
        {
            /*
             * change edges from here
             * for each 2 edges you have to increase the number in "directedGraph(0)" with 1
            */
            directedGraph graph = new directedGraph(6);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 4);
            graph.AddEdge(4, 4);
            graph.AddEdge(4, 5);
            graph.AddEdge(5, 5);

            //Print adjacency matrix
            graph.PrintAdjacecnyMatrix();

            /*
            * print the adjacency matrix 
            * change the number in graph.DFS to start traversal from a different vertex
            */
            Console.WriteLine("DFS traversal starting from vertex 1:");
            graph.DFS(0);
        }
    }
}