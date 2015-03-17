using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class CutOffLinkedListTest : CutOffLinkedList
	{
		[Theory]
		[MemberData("GetData")]
		public void JumpLinkedList(LinkedNode<int> root, int cutHead, int expectedHead, int cutTail, int expectedTail)
		{
			LinkedNode<int> head = root, tail = null;

			CutOff(ref head, ref tail, cutHead, cutTail);

			head.Value.Should().Be(expectedHead);
			tail.Value.Should().Be(expectedTail);
		}

		public static IEnumerable<object[]> GetData()
		{
			var root = new LinkedNode<int>(0);
			Enumerable.Range(1, 10).Aggregate(root, (node, i) => node.Next = new LinkedNode<int>(i));
			yield return new object[] { root, 3, 3, 3, 7 };
		}
	}
}