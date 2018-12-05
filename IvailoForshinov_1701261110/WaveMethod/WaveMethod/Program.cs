using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveMethod
{
    class Program
    {
        private int[,] mapMatrix;
        private int[] distance;
        private int[] visitedNodes;
        private void DijikstraAlgorithm()
        {
            for (int i = 0; i < this.distance.Length; i++)
            {
                if (this.mapMatrix[0, i] == 0)
                {
                    this.distance[i] = int.MaxValue;
                }
                else
                {
                    this.distance[i] = this.mapMatrix[0, i];
                }
                this.visitedNodes[i] = i;
            }
            this.visitedNodes[0] = -1;
            for (int j = 0; j < this.distance.Length / 2; j++)
            {
                int currentShortestWay = int.MaxValue;
                int nextNodeOnShortestWay = 0;
                for (int i = 0; i < this.distance.Length; i++)
                {
                    if ((this.distance[i] < currentShortestWay) && (this.visitedNodes[i] != -1))
                    {
                        currentShortestWay = this.distance[i];
                        nextNodeOnShortestWay = i;
                    }
                }
                for (int i = 0; i < this.distance.Length; i++)
                {
                    if (this.visitedNodes[i] != -1)
                    {
                        if (this.mapMatrix[nextNodeOnShortestWay, i] != 0)
                        {
                            if (this.distance[i] > this.distance[nextNodeOnShortestWay] +
                                    this.mapMatrix[nextNodeOnShortestWay, i])
                            {
                                int newDistance = this.distance[nextNodeOnShortestWay] +
                                    this.mapMatrix[nextNodeOnShortestWay, i];
                                this.distance[i] = newDistance;
                            }
                        }
                    }
                }
                this.visitedNodes[nextNodeOnShortestWay] = -1;
            }
        }
        private void CreateMap()
        {
            this.mapMatrix = new int[,]
            {
               {0, 7, 9, 0, 0, 14},
               {7, 0, 10, 15, 0, 0},
               {9, 10, 0, 11, 0, 2},
               {0, 15, 11, 0, 6, 0},
               {0, 0, 0, 6, 0, 9},
               {14, 0, 2, 0, 9, 0}
            };
            this.distance = new int[this.mapMatrix.GetLength(0)];
            this.visitedNodes = new int[this.mapMatrix.GetLength(0)];
        }
        private void PrintShortestWays()
        {
            for (int i = 0; i < this.distance.Length; i++)
            {
                if (this.distance[i] == int.MaxValue)
                {
                    Console.WriteLine("The shortest way to node: {0}, is – \"start point\"", i + 1);
                }
                else
                {
                    Console.WriteLine("The shortest way to node: {0}, is – {1}",
                        i + 1, this.distance[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Program test = new Program();
            test.CreateMap();
            test.DijikstraAlgorithm();
            test.PrintShortestWays();
        }
    }
}
