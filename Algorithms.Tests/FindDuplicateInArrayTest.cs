using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
	[TestClass]
	public class FindDuplicateInArrayTest : FindDuplicateInArray
	{
		[TestMethod]
		public void TestFindDuplicateInArray()
		{
			int[] arr = { 1, 3, 5, 2, 5 };

			foreach (var test in new Func<int[], int>[]
				{
					Do1, Do2, Do3, Do4,Do5, Do6, //Do7
				})
			{
				int r = test(arr);
				Assert.AreEqual(r, 5);
			}
		}
	}
}
