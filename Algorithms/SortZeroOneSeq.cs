using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class SortZeroOneSeq1 : ISort
	{
		public IList<int> Sort(IList<int> input)
		{
			var lists = new[]
			{
				new LinkedList<int>(),
				new LinkedList<int>()
			};

			foreach (var i in input)
			{
				lists[i].AddLast(i);
			}

			var output = new int[lists[0].Count + lists[1].Count];

			Array.Copy(lists[0].ToArray(), output, lists[0].Count);
			Array.Copy(lists[1].ToArray(), 0, output, lists[0].Count, lists[1].Count);

			return output;
		}
	}

	public class SortZeroOneSeq2 : ISort
	{
		public IList<int> Sort(IList<int> input)
		{
			var lists = new[]
			{
				new LinkedList<int>(),
				new LinkedList<int>()
			};

			foreach (var i in input)
			{
				lists[i].AddLast(i);
			}

			return ReadAll(lists).ToArray();
		}

		public IEnumerable<int> ReadAll(IEnumerable<IEnumerable<int>> input)
		{
			foreach (var arr in input)
			{
				foreach (var i in arr)
				{
					yield return i;
				}
			}
		}
	}

	public class SortZeroOneSeq3 : ISort
	{
		public IList<int> Sort(IList<int> input)
		{
			var lists = new[]
			{
				new LinkedList<int>(),
				new LinkedList<int>()
			};

			foreach (var i in input)
			{
				lists[i].AddLast(i);
			}

			var output = new int[lists[0].Count + lists[1].Count];

			var c = 0;
			foreach (var list in lists)
			{
				foreach (var i in list)
				{
					output[c++] = i;
				}
			}

			return output;
		}
	}

	public class SortZeroOneSeq4 : ISort
	{
		public IList<int> Sort(IList<int> input)
		{
			var lists = new[]
			{
				new LinkedList<int>(),
				new LinkedList<int>()
			};

			foreach (var i in input)
			{
				lists[i].AddLast(i);
			}

			var c = 0;
			foreach (var list in lists)
			{
				foreach (var i in list)
				{
					input[c++] = i;
				}
			}

			return input;
		}
	}

	public class SortZeroOneSeq5 : ISort
	{
		public IList<int> Sort(IList<int> input)
		{
			return input.OrderBy(i => i, new ZeroOneComparer())
						.ToArray();
		}

		class ZeroOneComparer : IComparer<int>
		{
			public int Compare(int x, int y)
			{
				if (x == y)
					return 0;

				if (x == 0)
					return -1;

				return 1;
			}
		}
	}
}