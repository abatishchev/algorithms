using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class RadixSort
	{
		private static IList<IList<int>> InitBuckets(int i)
		{
			return Enumerable.Range(0, i).Select(_ => new List<int>()).ToArray();
		}

		public void Sort(IList<int> input)
		{
			int maxLength = input.Max().ToString().Length;

			for (int i = 0; i < maxLength; i++)
			{
				var buckets = InitBuckets(10);

				foreach (int d in input)
				{
					int digit = (int)((d % Math.Pow(10, i + 1)) / Math.Pow(10, i));

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
	}
}