using System;
using System.Collections.Generic;

using Xunit;
using Xunit.Extensions;

namespace Algorithms.Tests
{
	public class ReverseLinkedListTest : ReverseLinkedList
	{
		[Theory, PropertyData("GetData")]
		public void ReverseLinkedList(Node a, Node b)
		{
			foreach (var test in new Func<Node, Node>[]
				{
					Do1,
					//Do2
				})
			{
				a = test(a);
				Assert.Equal(a, b, new NodeEqualityComparer());
			}
		}

		public static IEnumerable<object[]> GetData
		{
			get
			{
				yield return new object[] { CreateLinkedList.Do("BAR"), CreateLinkedList.Do("RAB") };
				yield return new object[] { CreateLinkedList.Do("AB"), CreateLinkedList.Do("BA") };
			}
		}
	}
}