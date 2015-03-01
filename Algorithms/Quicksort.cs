using System.Collections.Generic;

namespace Algorithms
{
	public class Quicksort : ISort
	{
		public void Sort(IList<int> input)
		{
			Sort(input, 0, input.Count - 1);
		}

		private static void Sort(IList<int> input, int low, int high)
		{
			if (low < high)
			{
				var pivot = Partition(input, low, high);
				Sort(input, low, pivot - 1);
				Sort(input, pivot + 1, high);
			}
		}

		private static int Partition(IList<int> input, int low, int high)
		{
			int pivot = input[low];

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
				else
				{
					return high;
				}
			}
		}
	}
}