using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class SumChildNodesTest
	{
		[Theory]
		[MemberData("GetData")]
		public void LinkListLooped(Type t, TreeNode<int> root, TreeNode<int> expected)
		{
			dynamic x = Activator.CreateInstance(t);

			x.UpdateTreeNode(root);

			root.Should().Be(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			Func<TreeNode<int>> gen = () => new TreeNode<int>(5)
			{
				Left = new TreeNode<int>(6)
				{
					Left = new TreeNode<int>(1),
					Right = new TreeNode<int>(2)
				},
				Right = new TreeNode<int>(4)
				{
					Right = new TreeNode<int>(3)
				}
			};
			var expected = new TreeNode<int>(21)
			{
				Left = new TreeNode<int>(9)
				{
					Left = new TreeNode<int>(1),
					Right = new TreeNode<int>(2)
				},
				Right = new TreeNode<int>(7)
				{
					Right = new TreeNode<int>(3)
				}
			};

			yield return new object[] { typeof(SumChildNodes1), gen(), expected };
			yield return new object[] { typeof(SumChildNodes2), gen(), expected };
		}
	}
}