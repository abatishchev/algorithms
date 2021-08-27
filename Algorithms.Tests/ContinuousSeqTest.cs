using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class ContinuousSeqTest : ContinuousSeq
	{
		[Theory]
		[MemberData(nameof(GetData))]
		public void ContinuousSeq(IEnumerable<int[]> seq, int[] expected)
		{
			int[] actual = GetContinuousSeq(seq);

			actual.Should().BeEquivalentTo(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			yield return new object[]
			{
				new[]
				{
					new[] { 5, 4 }, new[] { 6, 2 }, new[] { 9, 3 }, new[] { 2, 5 }, new[] { 4, 9 }
				},
				new[] { 4, 9 }
			};
		}
	}
}