using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class RadixSort : ISort
	{
		public void Sort(IList<int> input)
		{
			int maxLength = GetMaxLength(input);

			for (int i = 0; i < maxLength; i++)
			{
				var buckets = InitBuckets(10);

				foreach (int d in input)
				{
					var digit = GetDigit(d, i);

					buckets[digit].Add(d);
				}

				int index = 0;
				foreach (IList<int> list in buckets)
				{
					foreach (int d in list)
					{
						input[index++] = d;
					}
				}
			}
		}

		private static int GetMaxLength(IList<int> input)
		{
			return input.Max().ToString().Length;
		}

		private static IList<IList<int>> InitBuckets(int i)
		{
			return Enumerable.Range(0, i).Select(_ => new List<int>()).ToArray();
		}

		private static int GetDigit(int d, int i)
		{
			return (int)((d % Math.Pow(10, i + 1)) / Math.Pow(10, i));
		}
	}
}