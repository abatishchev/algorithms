using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class RemoveFromLinkedListTest : RemoveFromLinkedList
	{
		[Theory]
		[MemberData("GetData")]
		public void JumpLinkedList(LinkedNode<int> root, int n, LinkedNode<int> expected)
		{
			var actual = Remove(root, n);

			actual.Should().Be(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			yield return new object[] { Create(), 1, Create("123456789") };
			yield return new object[] { Create(), 3, Create("01345689") };
			yield return new object[] { Create(), 4, Create("01245789") };
		}

		private static LinkedNode<int> Create()
		{
			var nums = Enumerable.Range(0, 10).ToArray();
			return Create(nums);
		}

		private static LinkedNode<int> Create(string str)
		{
			var nums = str.ToCharArray().Select(i => Int32.Parse(i.ToString())).ToArray();
			return Create(nums);
		}

		private static LinkedNode<int> Create(ICollection<int> nums)
		{
			var root = new LinkedNode<int>(nums.First());
			nums.Skip(1).Aggregate(root, (node, i) => node.Next = new LinkedNode<int>(i));
			return root;
		}
	}
}