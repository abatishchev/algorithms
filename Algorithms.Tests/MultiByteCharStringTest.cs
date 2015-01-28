using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Algorithms.Tests
{
	public class MultiByteCharStringTest : MultiByteCharString
	{
		[Theory, MemberData("GetData")]
		public void MultiByteCharString(string input, string expected)
		{
			MultiByteChar[] result = Do(input);
			string actual = String.Join("    ", result.Select(b => b.ToString()));
			Assert.Equal(actual, expected);
		}

		public static IEnumerable<object[]> GetData
		{
			get
			{
				yield return new object[]
				{
					"1 0 0 0 1 0 1 0    1 1 0 1 0 1 1 0    0 0 0 1 0 1 1 1    1 1 0 1 0 1 0 0    1 0 1 1 1 0 1 0    0 1 0 1 1 1 1 1",
					"1 0 1 1 1 0 1 0    0 1 0 1 1 1 1 1    1 1 0 1 0 1 0 0    1 1 0 1 0 1 1 0    0 0 0 1 0 1 1 1    1 0 0 0 1 0 1 0"
				};
			}
		}
	}
}