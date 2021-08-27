using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class LongestStringTest : LongestString
	{
		[Theory]
		[MemberData(nameof(GetData))]
		public void LongestString(int n, IList<string> input, IList<string> expected)
		{
			var actual = GetLongestString(n, input);

			actual.Should().BeEquivalentTo(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			yield return new object[]
			{
				2,
				new[] { "looong", "word word", "a" },
				new[] { "word", "word" }
			};
		}
	}
}