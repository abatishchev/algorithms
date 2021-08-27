using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class WildcardTest : Wildcard
	{
		[Theory]
		[MemberData(nameof(GetData))]
		public void GetNumberOfOccurrencesTest(string pattern, string input, int expected)
		{
			int actual = GetNumberOfOccurrences(input, pattern);

			actual.Should().Be(expected);
		}

		[Theory]
		[MemberData(nameof(GetData))]
		public void ExpressionMatchesTest(string pattern, string input, int expected)
		{
			foreach (var t in new[] { typeof(Wildcard), typeof(Wildcard2) })
			{
				dynamic x = Activator.CreateInstance(t);

				bool actual = x.ExpressionMatches(input, pattern);

				actual.Should().Be(expected > 0);
			}
		}

		public static IEnumerable<object[]> GetData()
		{
			yield return new object[] { "a*b", "a0b", 1 };
			yield return new object[] { "a*b*c", "a0b0c", 1 };
			yield return new object[] { "a*a", "a0a0a", 3 };
			yield return new object[] { "a*b", "ab", 1 };

			yield return new object[] { "a*c", "a0d", 0 };
			yield return new object[] { "a*b*c", "a0b0d", 0 };

			yield return new object[] { "*a*b*", "ab", 1 };
			yield return new object[] { "*a*b*c*", "abc", 1 };
		}
	}
}