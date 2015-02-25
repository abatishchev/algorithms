using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class StringPermutationsTest : StringPermutations
	{
		[Theory]
		[MemberData("GetData")]
		public void StringPermutations(string input, string[] expected)
		{
			var actual = GetStringPermutations(input).ToArray();

			actual.ShouldBeEquivalentTo(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			yield return new object[]
			{
				"abc",
				new[] { "abc", "acb", "bac", "bca", "cab", "cba" }
			};
		}
	}
}