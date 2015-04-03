using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class CloneLinkedListTest : CloneLinkedList
	{
		[Theory]
		[MemberData("GetData")]
		public void CloneLinkedList(LinkedNode<int> root, string expected)
		{
			var actual = Clone(root);

			actual.ToString().Should().Be(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			var n4 = new LinkedNode<int>(4)
			{
				Next = null
			};
			var n3 = new LinkedNode<int>(3)
			{
				Next = n4
			};
			var n2 = new LinkedNode<int>(2)
			{
				Next = n3
			};
			var n1 = new LinkedNode<int>(1)
			{
				Next = n2
			};

			n1.Other = null;
			n2.Other = n4;
			n3.Other = n3;
			n4.Other = n1;

			yield return new object[]
			{
				n1,
				"1->2:4->3:3->4:1"
			};
		}
	}
}