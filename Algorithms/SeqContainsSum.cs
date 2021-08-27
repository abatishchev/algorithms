using System.Collections.Generic;

namespace Algorithms
{
	public class SeqContainsSum
	{
		public bool Contains(IList<int> seq, int c)
		{
			var dic = new Dictionary<int, int>(seq.Count);

			for (int i = 0; i < seq.Count; i++)
			{
				var a = seq[i];
				dic.Add(a, i);

				var b = c - a;
				if (dic.ContainsKey(b) && dic[b] != i)
				{
					return true;
				}
			}
			return false;
		}
	}
}
