using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public interface IMostFrequentElement
	{
		int FindMostFrequentElement(ICollection<int> input);
	}

	public class MostFrequentElement1 : IMostFrequentElement
	{
		public int FindMostFrequentElement(ICollection<int> input)
		{
			var dic = new Dictionary<int, int>();

			int k = -1, max = 0;

			foreach (var i in input)
			{
				int value;
				if (dic.TryGetValue(i, out value))
				{
					value++;
					dic[i] = value;

					if (value > max)
					{
						max = value;
						k = i;
					}
				}
				else
				{
					dic.Add(i, 1);
				}
			}

			return k;
		}
	}

	public class MostFrequentElement2 : IMostFrequentElement
	{
		public int FindMostFrequentElement(ICollection<int> input)
		{
			return input.GroupBy(i => i)
						.OrderBy(p => p.Count())
						.Last().Key;
		}
	}
}