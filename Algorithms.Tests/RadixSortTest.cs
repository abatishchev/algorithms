using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class RadixSortTest : RadixSort
	{
		[Theory]
		[MemberData("GetData")]
		public void RadixSort(IList<int> input, IList<int> expected)
		{
			Sort(input);

			input.ShouldBeEquivalentTo(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			yield return new object[]
			{
				new[] { 102, 23, 1, 301, 4, 89 },
				new[] { 1, 4, 23, 89, 102, 301 }
			};
		}
	}
}