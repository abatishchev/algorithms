﻿using System.Collections.Generic;

namespace Algorithms
{
	public class Quicksort : ISort
	{
		public IList<int> Sort(IList<int> input)
		{
			Sort(input, 0, input.Count - 1);

			return input;
		}

		private static void Sort(IList<int> input, int low, int high)
		{
			if (low >= high)
				return;

			var pivot = Partition(input, low, high);

			Sort(input, low, pivot - 1);

			Sort(input, pivot + 1, high);
		}

		private static int Partition(IList<int> input, int low, int high)
		{
			var pivot = input[(low + high) / 2];

			while (true)
			{
				while (input[low] < pivot)
					low++;

				while (input[high] > pivot)
					high--;

				if (low < high)
				{
					input.Swap(low, high);
				}
				else return high;
			}
		}
	}
}