using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class MergeSort : ISort
	{
		public void Sort(IList<int> input)
		{
			Sort(input, 0, input.Count - 1);
		}

		private static void Sort(IList<int> input, int start, int end)
		{
			if (end <= start)
				return;

			var mid = (start + end) / 2;

			Sort(input, start, mid);
			Sort(input, mid + 1, end);
			Merge(input, start, mid, end);
		}

		private static void Merge(IList<int> input, int start, int mid, int end)
		{
			var data = new List<int>(input);

			int index = start;

			while (start <= mid - 1 && mid <= end)
			{
				if (data[start] <= data[mid])
				{
					input[index++] = data[start++];
				}
				else
				{
					input[index++] = data[mid++];
				}
			}

			while (start <= mid - 1)
			{
				input[index++] = data[start++];
			}

			while (mid < end)
			{
				input[index++] = data[mid++];
			}

			for (int i = 0; i < end - start + 1; i++)
			{

				input[end] = data[end];
				end--;
			}
		}
	}
}