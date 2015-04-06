using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class StringPermutationsTest
	{
		[Theory]
		[MemberData("GetData")]
		public void StringPermutations(Type t, string input, string[] expected)
		{
			dynamic x = Activator.CreateInstance(t);

			string[] actual = x.GetPermutations(input);

			actual.ShouldBeEquivalentTo(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			const string input = "abc";
			string[] expected = { "abc", "acb", "bac", "bca", "cab", "cba" };

			yield return new object[] { typeof(StringPermutations1), input, expected };
			yield return new object[] { typeof(StringPermutations2), input, expected };
		}
	}
}