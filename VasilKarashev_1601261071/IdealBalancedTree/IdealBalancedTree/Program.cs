using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BalancedTree
{
	public class MainClass
	{
		static bool isBalanced(int[][] sons)
		{
			return isBalanced(sons, 0);
		}

		static bool isBalanced(int[][] sons, int startNode)
		{
			int[] children = sons[startNode];

			int minHeight = int.MaxValue;
			int maxHeight = int.MinValue;

			bool allChildBalanced = true;

			if (children.Length == 0)
				return true;
			else
			{
				foreach (int node in children)
				{
					int h = height(sons, node);
					if (h > maxHeight)
						maxHeight = h;

					if (h < minHeight)
						minHeight = h;
				}
			}
			foreach (int node in children)
			{
				allChildBalanced = allChildBalanced && isBalanced(sons, node);

				if (!allChildBalanced)
					return false;
			}
			return Math.Abs(maxHeight - minHeight) < 2 && allChildBalanced;
		}

		static int height(int[][] sons, int startNode)
		{
			int maxHeight = 0;

			foreach (int child in sons[startNode])
			{
				int thisHeight = height(sons, child);
				if (thisHeight > maxHeight)
					maxHeight = thisHeight;
			}
			return 1 + maxHeight;
		}

		public static void Main(string[] args)
		{
			int[][] sons = new int[6][];

			sons[0] = new int[] { 1, 2, 4 };
			sons[1] = new int[] { };
			sons[2] = new int[] { 3, 5 };
			sons[3] = new int[] { };
			sons[4] = new int[] { };
			sons[5] = new int[] { };

			Console.WriteLine(isBalanced(sons));
			Console.ReadKey();
		}

	}
}
