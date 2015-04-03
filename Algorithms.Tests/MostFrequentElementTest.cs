using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class MostFrequentElementTest
	{
		[Theory]
		[MemberData("GetData")]
		public void MostFrequentElement(Type t, ICollection<int> input, int expected)
		{
			var x = (IMostFrequentElement)Activator.CreateInstance(t);

			var actual = x.FindMostFrequentElement(input);

			actual.Should().Be(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			var input = new[] { 2, 3, 4, 5, 5, 3, 3 };
			const int expected = 3;

			yield return new object[] { typeof(MostFrequentElement1), input, expected };
			yield return new object[] { typeof(MostFrequentElement1), input, expected };
		}
	}
}