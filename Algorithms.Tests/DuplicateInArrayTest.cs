using System;
using Xunit;

namespace Algorithms.Tests
{
	public class DuplicateInArrayTest : DuplicateInArray
	{
		[Fact]
		public void DuplicateInArray()
		{
			int[] input = { 1, 3, 5, 2, 5 };
			const int duplicate = 5;

			foreach (var test in new Func<int[], int>[]
				{
					Do1, Do2, Do3, Do4,Do5, Do6, //Do7
				})
			{
				int actual = test(input);
				Assert.Equal(actual, duplicate);
			}
		}
	}
}