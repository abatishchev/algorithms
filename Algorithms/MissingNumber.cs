using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class MissingNumber
	{
		public int FindMissingNumber1(ICollection<int> input)
		{
			// naive way
			var sorted = input.OrderBy(i => i).ToArray();
			for (int i = 1; i < sorted.Length; i++)
			{
				int x = sorted[i - 1];
				int y = sorted[i];
				if (y - x != 1)
					return x + 1;
			}
			return -1;
		}

		public int FindMissingNumber2(IList<int> input)
		{
			// using the sum formula total = n*(n+1)/2

			int count = input.Count + 1; // existing number plus one missing
			int expected = count * (count + 1) / 2;

			int actual = input.Sum();
			// which is basically equal to:
			//foreach (int i in input)
			//{
			//	actual += i;
			//}

			return expected - actual;
		}

		public int FindMissingNumber3(ICollection<int> input)
		{
			// brute force using LINQ, less efficient but probably more readable

			return Enumerable.Range(1, input.Count + 1).Except(input).Single();
		}
	}
}