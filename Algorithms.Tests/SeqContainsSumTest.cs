using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class SeqContainsSumTest : SeqContainsSum
	{
		[Theory]
		[MemberData(nameof(GetData))]
		public void JumpLinkedList(IList<int> seq, int c, bool expected)
		{
			var actual = Contains(seq, c);

			actual.Should().Be(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			yield return new object[] { new[] { 2, 3 }, 5, true };
			//yield return new object[] { new[] { 2, 2 }, 4, true };

			yield return new object[] { new[] { 2, 3 }, 6, false };
			yield return new object[] { new[] { 2, 3 }, 7, false };
		}
	}
}