using System;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class ReverseStringTest
	{
		[Theory]
		[InlineData(typeof(ReverseString1))]
		[InlineData(typeof(ReverseString2))]
		[InlineData(typeof(ReverseString3))]
		[InlineData(typeof(ReverseString4))]
		[InlineData(typeof(ReverseString5))]
		public void ReverseString(Type t)
		{
			const string input = "abcdef", expected = "fedcba";

			var reverse = (IReverse)Activator.CreateInstance(t);

			string actual = reverse.Reverse(input);

			actual.Should().Be(expected);
		}
	}
}