using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class BinarySearchTest : BinarySearch
	{
		[Theory]
		[MemberData(nameof(GetData))]
		public void BinarySearch(IList<int> input, int key, int expected)
		{
			var actual = Find(input, key);

			actual.Should().Be(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			var arr = new[] { 1, 2, 3, 4, 5, 6 };

			yield return new object[] { arr, 6, 5 };
			yield return new object[] { arr, 1, 0 };
			yield return new object[] { arr, 3, 2 };
			yield return new object[] { arr, 0, -1 };
			yield return new object[] { arr, 7, -1 };

			var random = new Random();
			arr = Enumerable.Range(random.Next(25), random.Next(25)).ToArray();
			int key = arr[arr.Length / 2];
			yield return new object[] { arr, key, Array.IndexOf(arr, key) };
		}
	}
}