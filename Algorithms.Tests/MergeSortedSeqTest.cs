using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class MergeSortedSeqTest : MergeSortedSeq
	{
		[Theory]
		[MemberData("GetData")]
		public void MergeSortedSeq(IList<int> a, IList<int> b, IList<int> expected)
		{
			var actual = Merge(a, b).ToArray();

			actual.ShouldBeEquivalentTo(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			yield return new object[]
			{
				new[] { 1, 2, 3 },
				new[] { 4, 5, 6 },
				new[] { 1, 2, 3, 4, 5, 6 }
			};
			yield return new object[]
			{
				new[] { 4, 5, 6 },
				new[] { 1, 2, 3 },
				new[] { 1, 2, 3, 4, 5, 6 }
			};
		}
	}
}