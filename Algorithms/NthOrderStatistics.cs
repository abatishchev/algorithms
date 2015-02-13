using System;
using System.Collections.Generic;

namespace Algorithms
{
	public class NthOrderStatistics
	{
		/// <summary>
		/// Partitions the given list around a pivot element such that all elements on left of pivot are <= pivot and the ones at the right are > pivot.
		/// This method can be used for sorting, N-order statistics such as as median finding algorithms.
		/// Pivot is selected as last element in the list.
		/// </summary>
		private static int Partition(IList<int> list, int start, int end)
		{
			var pivot = list[end];
			var lastLow = start - 1;
			for (var i = start; i < end; i++)
			{
				int cur = list[i];
				if (cur <= pivot)
					Swap(list, i, ++lastLow);
			}
			Swap(list, end, ++lastLow);
			return lastLow;
		}

		private static int NthOrderStatistic(IList<int> list, int n, int start, int end)
		{
			while (true)
			{
				var pivotIndex = Partition(list, start, end);
				if (pivotIndex == n)
					return list[pivotIndex];

				if (n < pivotIndex)
					end = pivotIndex - 1;
				else if (n >= pivotIndex)
					start = pivotIndex + 1;
			}
		}

		/// <summary>
		/// Returns Nth smallest element from the list. Here n starts from 0 so that n=0 returns minimum, n=1 returns 2nd smallest element etc.
		/// </summary>
		public static int NthOrderStatistic(IList<int> list, int n)
		{
			return NthOrderStatistic(list, n, 0, list.Count - 1);
		}

		public static void Swap(IList<int> list, int i, int j)
		{
			if (i == j)   //This check is not required but Partition function may make many calls so its for perf reason
				return;
			var temp = list[i];
			list[i] = list[j];
			list[j] = temp;
		}

		public static int Median(IList<int> list)
		{
			return NthOrderStatistic(list, (list.Count - 1) / 2);
		}
	}
}