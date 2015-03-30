using System.Collections.Generic;

namespace Algorithms
{
	public class SeqContainsSum
	{
		public bool Contains(ICollection<int> seq, int c)
		{
			var set = new HashSet<int>(seq);

			foreach (var i in seq)
			{
				if (set.Contains(c - i))
				{
					return true;
				}
			}
			return false;
		}
	}
}