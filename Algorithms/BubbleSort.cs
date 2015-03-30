using System.Collections.Generic;

namespace Algorithms
{
	public class BubbleSort : ISort
	{
		public IList<int> Sort(IList<int> input)
		{
			for (int i = 0; i < input.Count; i++)
			{
				for (int j = i; j < input.Count; j++)
				{
					if (input[i] > input[j])
					{
						input.Swap(i, j);
					}
				}
			}
			return input;
		}
	}
}