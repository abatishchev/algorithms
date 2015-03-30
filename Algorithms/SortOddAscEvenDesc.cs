using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class SortOddAscEvenDesc1 : ISort
	{
		public IList<int> Sort(IList<int> input)
		{
			return input.OrderBy(i => i, new OddAscEvenDescComparer())
					  .ToArray();
		}
	}

	public class OddAscEvenDescComparer : IComparer<int>
	{
		public int Compare(int x, int y)
		{
			if (x == y)
				return 0;

			bool xe = IsEven(x), ye = IsEven(y);
			if (xe && ye)
			{
				return x.CompareTo(y) * -1;
			}
			if (xe)
			{
				return 1;
			}
			if (ye)
			{
				return -1;
			}
			return x.CompareTo(y);
		}

		private static bool IsEven(int i)
		{
			return i % 2 == 0;
		}
	}
}