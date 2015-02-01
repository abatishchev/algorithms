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
				yield return new[]
				{
				//			A							X							B							Y
				//   _______________    __________________________________    _______________    __________________________________

					"1 0 0 0 1 0 1 0    1 1 0 1 0 1 1 0    0 0 0 1 0 1 1 1    1 1 0 1 0 1 0 0    1 0 1 1 1 0 1 0    0 1 0 1 1 1 1 1",

					"1 0 1 1 1 0 1 0    0 1 0 1 1 1 1 1    1 1 0 1 0 1 0 0    1 1 0 1 0 1 1 0    0 0 0 1 0 1 1 1    1 0 0 0 1 0 1 0"
				//   __________________________________    _______________    __________________________________    _______________
				//					Y							B							X								A
				};
			}
		}
	}
}