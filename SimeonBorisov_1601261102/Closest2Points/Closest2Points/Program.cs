using System;
using System.Collections.Generic;
using System.Drawing;

namespace Demo
{
	// Class just used to return the result from FindClosestPoints()

	public sealed class Closest2Points
	{
		public Closest2Points(Point p1, Point p2)
		{
			_p1 = p1;
			_p2 = p2;
		}

		public Point P1 { get { return _p1; } }
		public Point P2 { get { return _p2; } }

		public double Distance()
		{
			double dx = P1.X - P2.X;
			double dy = P1.Y - P2.Y;

			return Math.Sqrt(dx * dx + dy * dy);
		}

		private readonly Point _p1;
		private readonly Point _p2;
	}

	public static class Program
	{
		public static void Main()
		{
			var listA = new List<Point>();
			listA.Add(new Point(10, 1));
			listA.Add(new Point(5, 5));
			listA.Add(new Point(15, 16));

			var listB = new List<Point>();
			listB.Add(new Point(1, 1));
			listB.Add(new Point(5, 8));
			listB.Add(new Point(15, 15));

			var answer = FindClosestPoints(listA, listB);

			Console.WriteLine("Closest points are {0} and {1}", answer.P1, answer.P2);
		}

		public static Closest2Points FindClosestPoints(IEnumerable<Point> seq1, IEnumerable<Point> seq2)
		{
			double closest = double.MaxValue;
			Closest2Points result = null;

			foreach (var p1 in seq1)
			{
				foreach (var p2 in seq2)
				{
					double dx = p1.X - p2.X;
					double dy = p1.Y - p2.Y;

					double distance = dx * dx + dy * dy;

					if (distance >= closest)
						continue;

					result = new Closest2Points(p1, p2);
					closest = distance;
				}
			}

			return result;
		}
	}
}