using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class HorsepoolTest : Horsepool
	{
		[Theory]
		[MemberData("GetData")]
		public void Horsepool(string input, string searchTerm, int expected)
		{
			int actual = IndexOf(input, searchTerm);

			actual.Should().Be(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			yield return new object[] { "abc", "ab", 0 };
			yield return new object[] { "cab", "ab", 1 };
		}
	}
}