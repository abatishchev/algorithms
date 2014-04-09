using System;
using System.Collections.Generic;

using Xunit;
using Xunit.Extensions;

namespace Algorithms.Tests
{
	public class LinkListPalindromeTest : LinkListPalindrome
	{
		[Theory, PropertyData("GetData")]
		public void LinkListPalindrome(Node root, bool expected)
		{
			foreach (var test in new Func<Node, bool>[]
				{
					Do1, Do2
				})
			{
				bool actual = test(root);
				Assert.Equal(actual, expected);
			}
		}

		public static IEnumerable<object[]> GetData
		{
			get
			{
				yield return new object[] { CreateLinkedList.Do("FOOBAR"), false };
				yield return new object[] { CreateLinkedList.Do("RADAR"), true };
			}
		}
	}
}