using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class PrimeNumbersTest : PrimeNumbers
	{
		[Theory]
		[MemberData(nameof(GetData))]
		public void PrimeNumbers(int max, ICollection<int> expected)
		{
			var actual = GetPrimeNumbers(17);

			actual.Should().BeEquivalentTo(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			yield return new object[] { 60, new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59 } };
		}
	}
}