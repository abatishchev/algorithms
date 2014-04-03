using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class FindDuplicateInArray
	{
		public static int Do1(int[] arr)
		{
			return arr.GroupBy(i => i)
					  .Single(g => g.Count() > 1).Key;
		}

		public static int Do2(int[] arr)
		{
			int[] temp = new int[arr.Length];

			for (int i = 0; i < arr.Length; i++)
			{
				int j = arr[i];

				if (temp[j - 1] == 0)
					temp[j - 1] = j;
				else
					return j;
			}
			return -1;
		}

		public static int Do3(int[] arr)
		{
			int[] temp = new int[arr.Length];

			for (int i = 0; i < arr.Length; i++)
			{
				int j = arr[i];

				if (temp[j - 1] >= 0)
					temp[j - 1] = -j;
				else
					return j;
			}
			return -1;
		}

		public static int Do4(int[] arr)
		{
			Array.Sort(arr);

			for (int i = 0; i < arr.Length - 1; i++)
			{
				if (arr[i] == arr[i + 1])
					return arr[i];
			}
			return -1;
		}

		public static int Do5(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = i + 1; j < arr.Length; j++)
				{
					if (arr[i] == arr[j])
						return arr[i];
				}
			}
			return -1;
		}

		public static int Do6(int[] arr)
		{
			var set = new HashSet<int>();

			for (int i = 0; i < arr.Length; i++)
			{
				int j = arr[i];
				if (!set.Contains(j))
					set.Add(j);
				else
					return j;
			}
			return -1;
		}

		public static int Do7(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				while (arr[arr[i]] != arr[i])
				{
					int t = arr[i];
					arr[i] = arr[arr[i]];
					arr[arr[i]] = t;
				}
			}

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] != i)
					return arr[i];
			}

			return -1;
		}
	}
}