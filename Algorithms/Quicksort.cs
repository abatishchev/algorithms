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
			var index = Partition(input, low, high);

			if (low < index - 1)
				Sort(input, low, index - 1);

			if (index < high)
				Sort(input, index, high);
		}

		private static int Partition(IList<int> input, int low, int high)
		{
			var pivot = input[(low + high) / 2];

			while (low <= high)
			{
				while (input[low] < pivot)
					low++;

				while (input[high] > pivot)
					high--;

				if (low <= high)
				{
					input.Swap(low, high);
					low++;
					high--;
				}
			}

			return low;
		}
	}
}