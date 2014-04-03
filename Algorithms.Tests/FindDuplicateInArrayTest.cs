using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
	[TestClass]
	public class FindDuplicateInArrayTest
	{
		[TestMethod]
		public void TestFindDuplicateInArray()
		{
			int[] arr = { 1, 3, 5, 2, 5 };

			foreach (var test in new Func<int[], int>[]
				{
					FindDuplicateInArray.Do1,
					FindDuplicateInArray.Do2,
					FindDuplicateInArray.Do3,
					FindDuplicateInArray.Do4,
					FindDuplicateInArray.Do5,
					FindDuplicateInArray.Do6,
					//FindDuplicateInArray.Do7
				})
			{
				int r = test(arr);
				Assert.AreEqual(r, 5);
			}
		}
	}
}
