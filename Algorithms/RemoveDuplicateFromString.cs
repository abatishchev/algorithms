using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
	public class RemoveDuplicateFromString
	{
		public string Remove(string input)
		{
			var set = new HashSet<char>();
			var sb = new StringBuilder();

			foreach (var c in input)
			{
				if (!set.Contains(c))
				{
					set.Add(c);
					sb.Append(c);
				}
			}
			return sb.ToString();
		}
	}
}