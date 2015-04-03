using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class RemoveDuplicateFromStringTest : RemoveDuplicateFromString
	{
		[Theory]
		[InlineData("zeerroo", "zero")]
		public void FindCommonElement2(string input, string expected)
		{
			string actual = Remove(input);

			actual.Should().Be(expected);
		}
	}
}