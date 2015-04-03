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

		public int Find(int[] a, int[] b, int[] c)
		{
			var setA = new HashSet<int>(a);
			var setB = new HashSet<int>(b);

			foreach (var x in c)
			{
				if (setA.Contains(x) && setB.Contains(x))
					return x;
			}

			return -1;
		}
	}
}