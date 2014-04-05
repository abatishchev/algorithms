using System;

using Algorithms;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
	[TestClass]
	public class ReverseStringTest : ReverseString
	{
		[TestMethod]
		public void TestReverseString()
		{
			string str = "abcdef";

			foreach (var test in new Func<string, string>[]
				{
					Do1, Do2, Do3, Do4
				})
			{
				string r = test(str);
				Assert.AreEqual(r, "fedcba");
			}
		} 
	}
}