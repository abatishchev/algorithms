using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class TopElementsFromSources
	{
		public int[] GetTopElements(int top, int[][] sources)
		{
			var queue = new FixedSizePriorityQueue(top, (x, y) => x < y);

			bool take = true;

			var arr = sources.Select((s, i) => new
			{
				Source = s,
				Enumerator = s.GetEnumerator(),
				Index = i
			}).ToArray();

			do
			{
				foreach (var x in arr)
				{
					if (x.Enumerator.MoveNext())
					{
						var i = (int)x.Enumerator.Current;
						bool res = queue.Enqueue(i);
						if (take && !res)
						{
							take = false;
						}
					}
				}

			} while (take);

			return queue.ToArray();
		}
	}
}