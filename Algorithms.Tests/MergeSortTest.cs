using System.Linq;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class MergeSortTest : MergeSort
	{
		[Fact]
		public void MergeSort()
		{
			var input = new[] { 102, 23, 1, 301, 4, 89 };

			var actual = Sort(input);

			actual.Should().BeInAscendingOrder()
			      .And.BeEquivalentTo(input.OrderBy(i => i));
		}
	}
}