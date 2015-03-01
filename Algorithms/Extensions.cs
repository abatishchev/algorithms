using System.Collections.Generic;

namespace Algorithms
{
	public static class Extensions
	{
		public static void Swap(this IList<int> list, int i, int j)
		{
			if (i == j)
				return;

			var temp = list[i];
			list[i] = list[j];
			list[j] = temp;
		}
	}
}