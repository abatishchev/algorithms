using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class MergeSort : ISort
	{
		public int[] Sort(int[] input)
		{
			if (input.Length <= 1)
			{
				return input;
			}

			int mid = input.Length / 2;
			var left = new int[mid];
			var right = new int[input.Length - mid];

			Array.Copy(input, left, mid);
			Array.Copy(input, mid, right, 0, right.Length);

			left = Sort(left);
			right = Sort(right);

			return MergeSortedSeq.Merge(left, right).ToArray();
		}

		IList<int> ISort.Sort(IList<int> input)
		{
			return Sort((int[])input);
		}
	}
}