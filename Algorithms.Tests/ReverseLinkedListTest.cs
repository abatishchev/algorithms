using System;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
	public class ReverseLinkedListTest : ReverseLinkedList
	{
		[Theory, MemberData("GetData")]
		public void ReverseLinkedList(LinkedNode a, LinkedNode b)
		{
			foreach (var test in new Func<LinkedNode, LinkedNode>[]
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