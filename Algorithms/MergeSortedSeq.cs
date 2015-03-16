using System.Collections.Generic;

namespace Algorithms
{
	public class MergeSortedSeq
	{
		public static IEnumerable<int> Merge(IList<int> arr1, IList<int> arr2)
		{
			bool a = true, b = true;
			int i = 0, j = 0;

			while (a || b)
			{
				if (a && b)
				{
					if (arr1[i] <= arr2[j])
					{
						yield return Advance(arr1, ref i, ref a);
					}
					else
					{
						yield return Advance(arr2, ref j, ref b);
					}
				}
				else if (a)
				{
					yield return Advance(arr1, ref i, ref a);
				}
				else if (b)
				{
					yield return Advance(arr2, ref j, ref b);
				}
			}
		}

		public static IEnumerable<int> Merge(IList<int> arr1, IList<int> arr2, IList<int> arr3)
		{
			bool a = true, b = true, c = true;
			int i = 0, j = 0, k = 0;

			while (a || b || c)
			{
				if (a && b)
				{
					if (arr1[i] <= arr2[j])
					{
						yield return Advance(arr1, ref i, ref a);
					}
					else if (arr2[j] <= arr1[i])
					{
						yield return Advance(arr2, ref j, ref b);
					}
				}
				if (a && c)
				{
					if (arr1[i] <= arr3[k])
					{
						yield return Advance(arr1, ref i, ref a);
					}
					else if (arr3[k] <= arr1[i])
					{
						yield return Advance(arr3, ref k, ref c);
					}
				}
				if (b && c)
				{
					if (arr2[j] <= arr3[k])
					{
						yield return Advance(arr2, ref j, ref b);
					}
					else if (arr3[k] <= arr2[j])
					{
						yield return Advance(arr3, ref k, ref c);
					}
				}
				if (a)
				{
					yield return Advance(arr1, ref i, ref a);
				}
				if (b)
				{
					yield return Advance(arr2, ref j, ref b);
				}
				if (c)
				{
					yield return Advance(arr3, ref k, ref c);
				}
			}
		}

		private static int Advance(IList<int> arr, ref int c, ref bool b)
		{
			c++;
			b = c < arr.Count;
			return arr[c - 1];
		}
	}
}