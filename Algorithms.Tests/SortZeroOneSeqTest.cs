using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class SortZeroOneSeqTest
	{
		[Theory]
		[MemberData("GetData")]
		public void SortOddAscEvenDesc(Type t, IList<int> input, ICollection<int> expected)
		{
			var sort = (ISort)Activator.CreateInstance(t);

			var actual = sort.Sort(input);

			actual.Should().Equal(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			Func<int[]> input = () => new[] { 1, 1, 0, 0, 1, 0, 1 };
			Func<int[]> expected = () => new[] { 0, 0, 0, 1, 1, 1, 1 };

			yield return new object[] { typeof(SortZeroOneSeq1), input(), expected() };
			yield return new object[] { typeof(SortZeroOneSeq2), input(), expected() };
			yield return new object[] { typeof(SortZeroOneSeq3), input(), expected() };
			yield return new object[] { typeof(SortZeroOneSeq4), input(), expected() };
			yield return new object[] { typeof(SortZeroOneSeq5), input(), expected() };
		}
	}
}