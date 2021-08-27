using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public interface IFindDuplicate
	{
		int Find(int[] input);
	}

	public class FindDuplicateElement1 : IFindDuplicate
	{
		public int Find(int[] input)
		{
			return input.GroupBy(i => i)
						.Single(g => g.Count() > 1).Key;
		}
	}

	public class FindDuplicateElement2 : IFindDuplicate
	{
		public int Find(int[] input)
		{
			int[] temp = new int[input.Length];

			for (int i = 0; i < input.Length; i++)
			{
				int j = input[i];

				if (temp[j - 1] == 0)
					temp[j - 1] = j;
				else
					return j;
			}
			return -1;
		}
	}

	public class FindDuplicateElement3 : IFindDuplicate
	{
		public int Find(int[] input)
		{
			int[] temp = new int[input.Length];

			for (int i = 0; i < input.Length; i++)
			{
				int j = input[i];

				if (temp[j - 1] >= 0)
					temp[j - 1] = -j;
				else
					return j;
			}
			return -1;
		}
	}

	public class FindDuplicateElement4 : IFindDuplicate
	{
		public int Find(int[] input)
		{
			Array.Sort(input);

			for (int i = 0; i < input.Length - 1; i++)
			{
				if (input[i] == input[i + 1])
					return input[i];
			}
			return -1;
		}
	}

	public class FindDuplicateElement5 : IFindDuplicate
	{
		public int Find(int[] input)
		{
			for (int i = 0; i < input.Length; i++)
			{
				for (int j = i + 1; j < input.Length; j++)
				{
					if (input[i] == input[j])
						return input[i];
				}
			}
			return -1;
		}
	}

	public class FindDuplicateElement6 : IFindDuplicate
	{
		public int Find(int[] input)
		{
			var set = new HashSet<int>();

			for (int i = 0; i < input.Length; i++)
			{
				int j = input[i];
				if (!set.Contains(j))
					set.Add(j);
				else
					return j;
			}
			return -1;
		}
	}
}