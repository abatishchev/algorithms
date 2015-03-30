using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class SortOddAscEvenDescTest
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
			int[] input = { 1, 2, 3, 4, 5, 6 }, expected = { 1, 3, 5, 6, 4, 2 };

			yield return new object[] { typeof(SortOddAscEvenDesc1), input, expected };
			yield return new object[] { typeof(SortOddAscEvenDesc2), input, expected };
		}
	}
}