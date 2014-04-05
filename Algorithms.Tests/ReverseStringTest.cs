using System;

using Xunit;
using Xunit.Extensions;

namespace Algorithms.Tests
{
	public class ReverseStringTest : ReverseString
	{
		[Theory, InlineData("abcdef", "fedcba")]
		public void ReverseString(string input, string expected)
		{
			foreach (var test in new Func<string, string>[]
				{
					Do1, Do2, Do3, Do4
				})
			{
				string actual = test(input);
				Assert.Equal(actual, expected);
			}
		}
	}
}