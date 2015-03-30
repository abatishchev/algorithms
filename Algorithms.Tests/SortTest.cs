using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class
		SortTest
	{
		[Theory]
		[MemberData("GetData")]
		public void Sort(Type t, IList<int> input)
		{
			var sort = (ISort)Activator.CreateInstance(t);

			var actual = sort.Sort(input);

			actual.Should().BeInAscendingOrder()
			      .And.BeEquivalentTo(input.OrderBy(i => i));
		}

		public static IEnumerable<object[]> GetData()
		{
			Func<int[]> gen = () => new[] { 102, 23, 1, 301, 4, 89 };

			yield return new object[] { typeof(RadixSort), gen() };
			yield return new object[] { typeof(CountSort), gen() };
			yield return new object[] { typeof(BubbleSort), gen() };
			yield return new object[] { typeof(Quicksort), gen() };
			yield return new object[] { typeof(MergeSort), gen() };
		}
	}
}