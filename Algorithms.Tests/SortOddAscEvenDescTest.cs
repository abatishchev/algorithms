using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class SortOddAscEvenDescTest : SortOddAscEvenDesc
	{
		[Theory]
		[MemberData("GetData")]
		public void SortOddAscEvenDesc(IList<int> input, ICollection<int> expected)
		{
			var actual = Sort(input);

			actual.Should().Equal(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			yield return new object[]
			{
				new[] { 1, 2, 3, 4, 5, 6 },
				new[] { 1, 3, 5, 6, 4, 2 }
			};
		}
	}
}