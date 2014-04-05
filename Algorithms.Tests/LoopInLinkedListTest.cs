using System;
using System.Collections.Generic;

using Xunit;
using Xunit.Extensions;

namespace Algorithms.Tests
{
	public class LoopInLinkedListTest : LoopInLinkedList
	{
		[Theory, PropertyData("GetData")]
		public void LoopInLinkedList(Node root, bool expected)
		{
			foreach (var test in new Func<Node, bool>[]
				{
					Do1, Do2, // Do3, Do4,Do5, Do6, //Do7
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
				yield return new object[] { Node.New(false), false };
				yield return new object[] { Node.New(true), true };
			}
		}
	}
}