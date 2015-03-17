using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public interface IShuffle
	{
		IList<int> Do(IList<int> values);
	}

	public class Shuffle1 : IShuffle
	{
		public IList<int> Do(IList<int> values)
		{
			var random = new Random();

			values = values.OrderBy(_ => random.Next()).ToArray();

			return values;
		}
	}

	public class Shuffle2 : IShuffle
	{
		public IList<int> Do(IList<int> values)
		{
			var random = new Random();
			for (int i = 1; i < values.Count; i++)
			{
				values.Swap(i, random.Next(0, i - 1));
			}
			return values;
		}
	}
}