using Xunit;

namespace Algorithms.Tests
{
	public class TriangleTest : Triangle
	{
		[Theory]

		// one or more is zero
		[InlineData(0, 1, 2, TriangleType.Error)]
		[InlineData(1, 0, 2, TriangleType.Error)]
		[InlineData(1, 2, 0, TriangleType.Error)]
		[InlineData(1, 0, 0, TriangleType.Error)]
		[InlineData(0, 1, 0, TriangleType.Error)]
		[InlineData(0, 0, 1, TriangleType.Error)]
		[InlineData(0, 0, 0, TriangleType.Error)]

		// one or more is negative
		[InlineData(-1, 1, 2, TriangleType.Error)]
		[InlineData(1, -1, 2, TriangleType.Error)]
		[InlineData(1, 2, -1, TriangleType.Error)]
		[InlineData(1, -1, -1, TriangleType.Error)]
		[InlineData(-1, 1, -1, TriangleType.Error)]
		[InlineData(-1, -1, 1, TriangleType.Error)]

		// theorem violation
		[InlineData(1, 1, 3, TriangleType.Error)]
		[InlineData(1, 3, 1, TriangleType.Error)]
		[InlineData(3, 1, 1, TriangleType.Error)]

		// all sides are equal
		[InlineData(1, 1, 1, TriangleType.Equilateral)]

		// two sides are equal
		[InlineData(2, 2, 3, TriangleType.Isosceles)]
		[InlineData(3, 5, 3, TriangleType.Isosceles)]
		[InlineData(5, 4, 4, TriangleType.Isosceles)]

		// all sides are different
		[InlineData(1, 2, 3, TriangleType.Scalene)]
		[InlineData(1, 3, 2, TriangleType.Scalene)]
		[InlineData(3, 2, 1, TriangleType.Scalene)]
		public void Test(int a, int b, int c, TriangleType expected)
		{
			TriangleType actual = Do(a, b, c);

			Assert.Equal(actual, expected);
		}
	}
}