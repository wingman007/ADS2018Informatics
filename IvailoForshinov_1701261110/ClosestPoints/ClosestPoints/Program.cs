using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PointByClosestDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            var sortedPoints = PointsSorter.OrderByDistance(PointsSorter.GeneratePoints(50000),
                   50, 50);

            foreach (var sp in sortedPoints)
            {
                Console.WriteLine(sp.X + " " + sp.Y);
            }
        }
    }

    [DebuggerDisplay("X={X}, Y={Y}")]
    internal sealed class Point
    {
        public readonly double X;
        public readonly double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    internal static class PointsSorter
    {
        public static List<Point> GeneratePoints(int count)
        {
            Random rnd = new Random();
            List<Point> tmp = new List<Point>(count);
            for (int i = 0; i < count; i++)
            {
                tmp.Add(new Point(rnd.NextDouble() * 10000 - 5000, rnd.NextDouble() * 10000 - 5000));
            }
            return tmp;
        }

        private static double Pow2(double x)
        {
            return x * x;
        }

        private static double Distance2(Point p1, Point p2)
        {
            return Pow2(p2.X - p1.X) + Pow2(p2.Y - p1.Y);
        }

        private static Tuple<Point, double> GetNearestPoint(Point toPoint, LinkedList<Point> points)
        {
            Point nearestPoint = null;
            double minDist2 = double.MaxValue;
            foreach (Point p in points)
            {
                double dist2 = Distance2(p, toPoint);
                if (dist2 < minDist2)
                {
                    minDist2 = dist2;
                    nearestPoint = p;
                }
            }
            return new Tuple<Point, double>(nearestPoint, minDist2);
        }

        public static List<Point> OrderByDistance(List<Point> points, int gridNx, int gridNy)
        {
            if (points.Count == 0)
                return points;

            double minX = points[0].X;
            double maxX = minX;
            double minY = points[0].Y;
            double maxY = minY;

            // Find the entire space occupied by the points
            foreach (Point p in points)
            {
                double x = p.X;
                double y = p.Y;

                if (x < minX)
                    minX = x;
                else if (x > maxX)
                    maxX = x;

                if (y < minY)
                    minY = y;
                else if (y > maxY)
                    maxY = y;
            }

            // The trick to avoid out of range
            maxX += 0.0001;
            maxY += 0.0001;

            double minCellSize2 = Pow2(Math.Min((maxX - minX) / gridNx, (maxY - minY) / gridNy));

            // Create cells subsets
            LinkedList<Point>[,] cells = new LinkedList<Point>[gridNx, gridNy];

            for (int j = 0; j < gridNy; j++)
                for (int i = 0; i < gridNx; i++)
                    cells[i, j] = new LinkedList<Point>();

            Func<Point, Tuple<int, int>> getPointIndices = p =>
            {
                int i = (int)((p.X - minX) / (maxX - minX) * gridNx);
                int j = (int)((p.Y - minY) / (maxY - minY) * gridNy);
                return new Tuple<int, int>(i, j);
            };

            foreach (Point p in points)
            {
                var indices = getPointIndices(p);
                cells[indices.Item1, indices.Item2].AddLast(p);
            }

            List<Point> ordered = new List<Point>(points.Count);

            Point nextPoint = points[0];
            while (ordered.Count != points.Count)
            {
                Point p = nextPoint;
                var indices = getPointIndices(p);
                int pi = indices.Item1;
                int pj = indices.Item2;

                ordered.Add(p);
                cells[pi, pj].Remove(p);

                int radius = 1;
                int maxRadius = Math.Max(Math.Max(pi, cells.GetLength(0) - pi), Math.Max(pj, cells.GetLength(1) - pj));

                double[] minDist2 = { double.MaxValue };    // To avoid access to modified closure
                Point nearestPoint = null;

                while ((nearestPoint == null || minDist2[0] > minCellSize2 * (radius - 1)) && radius < maxRadius)
                {
                    int minI = Math.Max(pi - radius, 0);
                    int minJ = Math.Max(pj - radius, 0);
                    int maxI = Math.Min(pi + radius, cells.GetLength(0) - 1);
                    int maxJ = Math.Min(pj + radius, cells.GetLength(1) - 1);

                    // Find the nearest point in the (i, j)-subset action
                    Action<int, int> findAction = (i, j) =>
                    {
                        if (cells[i, j].Count != 0)
                        {
                            var areaNearestPoint = GetNearestPoint(p, cells[i, j]);
                            if (areaNearestPoint.Item2 < minDist2[0])
                            {
                                minDist2[0] = areaNearestPoint.Item2;
                                nearestPoint = areaNearestPoint.Item1;
                            }
                        }
                    };

                    if (radius == 1)
                    {
                        // Iterate through all indexes in the 3x3
                        for (int j = minJ; j <= maxJ; j++)
                        {
                            for (int i = minI; i <= maxI; i++)
                            {
                                findAction(i, j);
                            }
                        }
                    }
                    else
                    {
                        // Iterate through border only
                        for (int i = minI; i < maxI; i++)
                        {
                            findAction(i, minJ);
                        }
                        for (int j = minJ; j < maxJ; j++)
                        {
                            findAction(maxI, j);
                        }
                        for (int i = minI + 1; i <= maxI; i++)
                        {
                            findAction(i, maxJ);
                        }
                        for (int j = minJ + 1; j <= maxJ; j++)
                        {
                            findAction(minI, j);
                        }
                    }

                    radius++;
                }
                nextPoint = nearestPoint;
            }
            return ordered;
        }
    }
}