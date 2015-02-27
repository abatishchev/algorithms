using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class SortTest
	{
		[Theory]
		[MemberData("GetData")]
		public void Sort(Type t, IList<int> input, IList<int> expected)
		{
			var sort = (ISort)Activator.CreateInstance(t);
			sort.Sort(input);

			input.ShouldBeEquivalentTo(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			var originial = new[] { 102, 23, 1, 301, 4, 89 };
			var sorted = new[] { 1, 4, 23, 89, 102, 301 };

			yield return new object[] { typeof(RadixSort), originial, sorted };
			yield return new object[] { typeof(CountSort), originial, sorted };
		}
	}
}