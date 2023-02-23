using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllPossiblePaths
{
    internal class Program
    {
		static List<int[]> totalPaths = new List<int[]>();
		static int destiX;
		static int destiY;
		static int sourceX;
		static int sourceY;
		static void Main(string[] args)
		{
			var sep = new char[] { ' ' };
			var line = Console.ReadLine().Split(sep);
			int n = int.Parse(line[0]);
			int m = int.Parse(line[1]);
			int[,] table = new int[n, m];
			for (int i = 0; i < n; i++)
			{
				var charges = Console.ReadLine().Split(sep);
				for (int j = 0; j < m; j++)
				{
					table[i, j] = int.Parse(charges[j]);
				}
			}
			line = Console.ReadLine().Split(sep);
			sourceX = int.Parse(line[0]);
			sourceY = int.Parse(line[1]);
			line = Console.ReadLine().Split(sep);
			destiX = int.Parse(line[0]);
			destiY = int.Parse(line[1]);

			var slope = (destiY - sourceY) / (destiX - sourceX);
			if (slope > 0 || true)
			{
				var currentPath = new List<int>();
				findNextPath(currentPath, sourceX, sourceY, table);
				Console.WriteLine("Total Paths: {0}", totalPaths.Count);
			}
			else
			{
				Console.WriteLine(-1); //Slope is not positive. 
			}
			Console.ReadKey();
		}

		static void findNextPath(List<int> currentPath, int x, int y, int[,] table)
		{
			if (sourceX != x || sourceY != y)
			{
				currentPath.Add(x);
				currentPath.Add(y);
			}
			if (destiX == x && destiY == y)
			{
				totalPaths.Add(currentPath.ToArray());
				Console.Write("Path {0}: ", totalPaths.Count);
				for (int i = 0; i < currentPath.Count; i = i + 2)
					Console.Write("{0},", table[currentPath[i], currentPath[i + 1]]);
				Console.WriteLine();
				currentPath.RemoveAt(currentPath.Count - 1);
				currentPath.RemoveAt(currentPath.Count - 1);
				return;
			}
			if (y < destiY)
				findNextPath(currentPath, x, y + 1, table);
			if (x > destiX)
				findNextPath(currentPath, x - 1, y, table);
			if (x - 1 >= destiX && y + 1 <= destiY)
				findNextPath(currentPath, x - 1, y + 1, table);
			if (currentPath.Count > 1)
			{
				currentPath.RemoveAt(currentPath.Count - 1);
				currentPath.RemoveAt(currentPath.Count - 1);
			}

		}

	}
}
