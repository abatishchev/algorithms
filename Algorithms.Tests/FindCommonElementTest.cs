using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class FindCommonElementTest : FindCommonElement
	{
		[Theory]
		[MemberData("GetData")]
		public void FindCommonElement(int[] a, int[] b, int expected)
		{
			int actual = Find(a, b);

			actual.Should().Be(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			yield return new object[]
			{
				new[] { 1, 2, 3, 4, 5 },
				new[] { 6, 7, 8, 3, 9 },
				3
			};
			yield return new object[]
			{
				new[] { 1, 2, 3, 4, 5 },
				new[] { 6, 7, 8, 9, 0 },
				-1
			};
		}
	}
}