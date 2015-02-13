using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
	public class QuicksortTest : Quicksort
	{
		[Theory]
		[MemberData("GetData")]
		public void QuickSort(int[] input, int[] expected)
		{
			int[] actual = Do(input);

			Assert.Equal(actual, expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			yield return new object[] { new[] { 5, 4, 3, 1, 2 }, new[] { 1, 2, 3, 4, 5 } };
		}
	}
}