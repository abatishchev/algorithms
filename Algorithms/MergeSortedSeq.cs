using System.Collections.Generic;

namespace Algorithms
{
	public class MergeSortedSeq
	{
		public IEnumerable<int> Merge(IList<int> arr1, IList<int> arr2)
		{
			bool a = true, b = true;
			int i = 0, j = 0;

			while (a || b)
			{
				if (a && b)
				{
					if (arr1[i] <= arr2[j])
					{
						yield return arr1[i];
						i++;
						a = i < arr1.Count;
					}
					else
					{
						yield return arr2[j];
						j++;
						b = j < arr2.Count;
					}
				}
				else if (a)
				{
					yield return arr1[i];
					i++;
					a = i < arr1.Count;
				}
				else if (b)
				{
					yield return arr2[j];
					j++;
					b = j < arr2.Count;
				}
			}
		}
	}
}
