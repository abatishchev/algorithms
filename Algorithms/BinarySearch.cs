using System.Collections.Generic;

namespace Algorithms
{
	public class BinarySearch
	{
		public int Find(IList<int> input, int key)
		{
			if (input.Count == 0)
				return -1;
			if (key < input[0])
				return -1;
			if (key > input[input.Count - 1])
				return -1;

			return Find(input, key, 0, input.Count - 1);
		}

		private static int Find(IList<int> input, int key, int lo, int hi)
		{
			int mid = (lo + hi) / 2;

			if (key < input[mid])
				return Find(input, key, lo, mid - 1);
			if (key > input[mid])
				return Find(input, key, mid + 1, hi);

			return mid;
		}
	}
}