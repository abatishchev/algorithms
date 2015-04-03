using System;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class FindDuplicateElementTest
	{
		[Theory]
		[InlineData(typeof(FindDuplicateElement1))]
		[InlineData(typeof(FindDuplicateElement2))]
		[InlineData(typeof(FindDuplicateElement3))]
		[InlineData(typeof(FindDuplicateElement4))]
		[InlineData(typeof(FindDuplicateElement5))]
		[InlineData(typeof(FindDuplicateElement6))]
		public void FindDuplicateElement(Type t)
		{
			int[] input = { 1, 3, 5, 2, 5 };
			const int expected = 5;

			var find = (IFindDuplicate)Activator.CreateInstance(t);

			int actual = find.Find(input);

			actual.Should().Be(expected);
		}
	}
}