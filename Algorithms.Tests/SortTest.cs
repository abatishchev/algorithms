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
		[MemberData(nameof(GetData))]
		public void Sort(Type t, IList<int> input)
		{
			var sort = (ISort)Activator.CreateInstance(t);

			var actual = sort.Sort(input);

			actual.Should().BeInAscendingOrder()
				  .And.BeEquivalentTo(input.OrderBy(i => i));
		}

		private static readonly Random _randon = new Random();

		public static IEnumerable<object[]> GetData()
		{
			var seq = Enumerable.Range(0, 25).OrderBy(i => _randon.Next());

			yield return new object[] { typeof(RadixSort), seq.ToArray() };
			yield return new object[] { typeof(CountSort), seq.ToArray() };
			yield return new object[] { typeof(BubbleSort), seq.ToArray() };
			yield return new object[] { typeof(Quicksort), seq.ToArray() };
			yield return new object[] { typeof(MergeSort), seq.ToArray() };
		}
	}
}