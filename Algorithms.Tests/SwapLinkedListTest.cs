using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class SwapLinkedListTest : SwapLinkedList
	{
		[Theory]
		[MemberData(nameof(GetData))]
		public void SwapEvenNodes(LinkedNode<int> root)
		{
			root = SwapEven(root);

			root.ToString().Should().Be("1->4->3->6->5->8->7->10->9->12->11->2");
		}

		public static IEnumerable<object[]> GetData()
		{
			var root = new LinkedNode<int>(1);
			Enumerable.Range(root.Value + 1, 11).Aggregate(root, (node, i) => node.Next = new LinkedNode<int>(i));
			yield return new object[] { root };
		}
	}
}