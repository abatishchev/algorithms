using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class CountSort : ISort
	{
		public void Sort(IList<int> input)
		{
			int max = input.Max();

			for (int i = 0; i < max; i++)
			{
				var counts = InitCounts(max + 1);

				foreach (var num in input)
				{
					counts[num]++;
				}

				int index = 0;
				for (i = 0; i < counts.Length; i++)
				{
					for (int j = 0; j < counts[i]; j++)
					{
						input[index++] = i;
					}
				}
			}
		}

		private static int[] InitCounts(int i)
		{
			return Enumerable.Range(0, i).Select(_ => 0).ToArray();
		}
	}
}