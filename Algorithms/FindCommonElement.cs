using System.Collections.Generic;

namespace Algorithms
{
	public class FindCommonElement
	{
		public int Find(int[] a, int[] b)
		{
			int[] greater, smaller;
			if (a.Length <= b.Length)
			{
				greater = b;
				smaller = a;
			}
			else
			{
				greater = a;
				smaller = b;
			}

			var set = new HashSet<int>(greater);
			foreach (var c in smaller)
			{
				if (set.Contains(c))
					return c;
			}
			return -1;
		}
	}
}