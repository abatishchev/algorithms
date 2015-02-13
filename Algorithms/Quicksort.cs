namespace Algorithms
{
	public class Quicksort
	{
		public int[] Do(int[] arr)
		{
			quicksort(arr, 0, arr.Length - 1);
			return arr;
		}

		public void quicksort(int[] input, int low, int high)
		{
			if (low < high)
			{
				var pivot = partition(input, low, high);
				quicksort(input, low, pivot - 1);
				quicksort(input, pivot + 1, high);
			}
		}

		private static int partition(int[] input, int low, int high)
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
					swap(input, low, high);
				}
				else
				{
					return high;
				}
			}
		}

		private static void swap(int[] input, int a, int b)
		{
			var temp = input[a];
			input[a] = input[b];
			input[b] = temp;
		}
	}
}