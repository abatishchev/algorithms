using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class MissingNumberTest : MissingNumber
	{
		[Theory]
		[MemberData(nameof(GetData))]
		public void MissingNumber1(ICollection<int> numbers, int expected)
		{
			int actual = FindMissingNumber1(numbers);

			actual.Should().Be(expected);
		}

		[Theory]
		[MemberData(nameof(GetData))]
		public void MissingNumbe2(IList<int> numbers, int expected)
		{
			int actual = FindMissingNumber2(numbers);

			actual.Should().Be(expected);
		}

		[Theory]
		[MemberData(nameof(GetData))]
		public void MissingNumbe3(ICollection<int> numbers, int expected)
		{
			int actual = FindMissingNumber3(numbers);

			actual.Should().Be(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			yield return new object[]
			{
				new[] { 1, 5, 2, 3 }, 4
			};
		}
	}
}