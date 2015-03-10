using System;
using System.Collections.Generic;
using System.Threading;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class WildcardTest : Wildcard
	{
		[Theory]
		[MemberData("GetData")]
		public void GetNumberOfOccurrences(string pattern, string input, int expected)
		{
			int actual = GetNumberOfOccurrences(input, pattern);

			actual.Should().Be(expected);
		}

		[Theory]
		[MemberData("GetData")]
		public void ExpressionMatches(string pattern, string input, int expected)
		{
			foreach (var t in new[] { typeof(Wildcard), typeof(Wildcard2) })
			{
				var w = (IWildcard)Activator.CreateInstance(t);

				var actual = w.ExpressionMatches(input, pattern);

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