using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickLuckyBox
{
    internal class Program
    {
		static void Main(string[] args)
		{
			//Write code here
			var size = short.Parse(Console.ReadLine());
			var table = new int[size, size];
			for (short i = 0; i < size; i++)
			{
				var inputs = Console.ReadLine().Split(new char[] { '#' }); // To capture money value of blocks.
				for (short j = 0; j < size; j++)
				{
					table[i, j] = int.Parse(inputs[j]); // assigning money value to respetive blocks.
				}
			}
			Func<short, short, int> findMinimumPosibleMoneyAmount = (ro, co) => {
				int minValue = int.MaxValue;
				for (var i = ro - 1; i < ro + 2; i++)
				{
					if (i < 0 || i >= size)
						continue;
					for (var j = co - 1; j < co + 2; j++)
					{
						if (j < 0 || j >= size)
							continue;
						//Console.Write("({0})",table[i,j]);
						if (minValue > table[i, j])
						{
							minValue = table[i, j];
						}
					}
				}
				//Console.Write(minValue);
				return minValue;
			}; // Func expression closed 

			var blocks = new Block[size * size];
			short count = 0;
			for (short r = 0; r < size; r++)
			{
				for (short c = 0; c < size; c++)
				{
					blocks[count] = new Block();
					//Console.Write("{0}#{1} : ",r,c);
					blocks[count].Value = findMinimumPosibleMoneyAmount(r, c);
					blocks[count].rowNo = r;
					blocks[count].columnNo = c;
					//Console.WriteLine();
					count++;
				}
			}
			var filtered = blocks.Where(c => c.Value == blocks.Max(b => b.Value));
			foreach (var b in filtered)
			{
				Console.WriteLine("{0}#{1}", b.rowNo + 1, b.columnNo + 1);
			}


		} // close main
		class Block // private class 
		{
			public short rowNo { get; set; }
			public short columnNo { get; set; }
			public int Value { get; set; }
		}
	}
}
