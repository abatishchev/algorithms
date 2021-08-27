using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class LongestString
	{
		public IList<string> GetLongestString(int nTh, IList<string> input)
		{
			if (nTh <= 0)
				throw new ArgumentOutOfRangeException("nTh");
			if (input == null || input.Count < 1)
				throw new ArgumentException("input");

			var dic = GroupByLength(input);
			// or
			var dic2 = input.Select(str => str.Split(' '))
							.SelectMany(str => str)
							.GroupBy(s => s.Length)
							.ToDictionary(g => g.Key, g => g.ToArray());
			// or use 
			//new SortedList<int, IList<string>>(new DescendingOrderComparer());

			return dic.OrderByDescending(p => p.Key)
					  .ElementAt(nTh - 1) // zero-based indexing
					  .Value;
		}

		private static Dictionary<int, IList<string>> GroupByLength(IList<string> input)
		{
			var dic = new Dictionary<int, IList<string>>();
			foreach (var str in input)
			{
				foreach (var word in str.Split(' '))
				{
					// if needed, current task language doesn't require it
					//word = RemovePunctuation(word);

					IList<string> list;
					if (dic.TryGetValue(word.Length, out list))
					{
						list.Add(word);
					}
					else
					{
						dic.Add(word.Length, new List<string> { word });
					}
				}
			}
			return dic;
		}

		private static string RemovePunctuation(string word)
		{
			return new string(word.Where(c => !Char.IsPunctuation(c)).ToArray());
		}
	}
}