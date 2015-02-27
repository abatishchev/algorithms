using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class TopElementsFromSources
	{
		public int[] GetTopElements(int top, int[][] sources)
		{
			var queue = new FixedSizePriorityQueue(top, (x, y) => x <= y);

			bool take = true;

			do
			{
				var remove = new List<int[]>();
				foreach (var x in sources.Select(s => new { Source = s, Enumerator = s.GetEnumerator() }))
				{
					if (x.Enumerator.MoveNext())
					{
						bool r = queue.Enqueue((int)x.Enumerator.Current);
						if (take)
							take = r;
					}
					else
					{
						remove.Add(x.Source);
					}
				}

				sources = sources.Except(remove).ToArray();

			} while (take);

			return queue.ToArray();
		}
	}
}