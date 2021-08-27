using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class FindCommonElementTest : FindCommonElement
	{
		[Theory]
		[InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 6, 7, 8, 3, 9 }, 3)]
		[InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 6, 7, 8, 9, 0 }, -1)]
		public void FindCommonElement2(int[] a, int[] b, int expected)
		{
			int actual = Find(a, b);

			actual.Should().Be(expected);
		}

		[Theory]
		[InlineData(new[] { 1, 2, 3 }, new[] { 3, 4, 5 }, new[] { 3, 0, 0 }, 3)]
		public void FindCommonElement3(int[] a, int[] b, int[] c, int expected)
		{
			int actual = Find(a, b, c);

			actual.Should().Be(expected);
		}
	}
}