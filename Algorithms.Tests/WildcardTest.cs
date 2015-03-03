using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class WildcardTest : Wildcard
	{
		[Theory]
		[MemberData("GetData")]
		public void Wildcard(string pattern, string input, int expected)
		{
			int actual = GetNumberOfOccurrences(pattern, input);

			actual.Should().Be(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			yield return new object[] { "a*b", "a0b", 1 };
			yield return new object[] { "a*b*c", "a0b0c", 1 };
			//yield return new object[] { "a*a", "a0a0a", 3 };
			//yield return new object[] { "a*b", "ab", 1 };
		}
	}
}