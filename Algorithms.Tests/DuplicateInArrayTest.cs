using System;
using System.Collections.Generic;

using Xunit;
using Xunit.Extensions;

namespace Algorithms.Tests
{
	public class DuplicateInArrayTest : DuplicateInArray
	{
		[Theory, PropertyData("GetData")]
		public void DuplicateInArray(int[] input, int missing)
		{
			foreach (var test in new Func<int[], int>[]
				{
					Do1, Do2, Do3, Do4,Do5, Do6, //Do7
				})
			{
				int actual = test(input);
				Assert.Equal(actual, missing);
			}
		}

		public static IEnumerable<object[]> GetData
		{
			get
			{
				yield return new object[] { new[] { 1, 3, 5, 2, 5 }, 5 };
			}
		}
	}
}
