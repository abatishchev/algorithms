using System;
using System.Collections.Generic;

using Xunit;
using Xunit.Extensions;

namespace Algorithms.Tests
{
	public class LinkListLoopedTest : LinkListLooped
	{
		[Theory, PropertyData("GetData")]
		public void LinkListLooped(Node root, bool expected)
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
				yield return new object[] { CreateLinkedList.Do(), false };

				Node looped = CreateLinkedList.Do();
				looped.Next.Next = looped;

				yield return new object[] { looped, true };
			}
		}
	}
}