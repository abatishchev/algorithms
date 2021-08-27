using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class MergeSortedSeqTest : MergeSortedSeq
	{
		[Theory]
		[MemberData(nameof(GetData2))]
		public void MergeSortedSeq2(IList<int> a, IList<int> b, IList<int> expected)
		{
			var actual = Merge(a, b).ToArray();

			actual.Should().BeEquivalentTo(expected);
		}

		[Theory]
        [MemberData(nameof(GetData3))]
		public void MergeSortedSeq3(IList<int> a, IList<int> b, IList<int> c, IList<int> expected)
		{
			var actual = Merge(a, b, c).ToArray();

			actual.Should().BeEquivalentTo(expected);
		}

		public static IEnumerable<object[]> GetData2()
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

		public static IEnumerable<object[]> GetData3()
		{
			yield return new object[]
			{
				new[] { 1, 2 },
				new[] { 4, 5 },
				new[] { 3, 4 },
				new[] { 1, 2, 3, 4, 4, 5 }
			};
		}
	}
}