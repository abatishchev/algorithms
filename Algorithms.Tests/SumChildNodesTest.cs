using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class SumChildNodesTest : SumChildNodes
	{
		[Theory]
		[MemberData("GetData")]
		public void LinkListLooped(TreeNode<int> root, TreeNode<int> expected)
		{
			UpdateTreeNode(root);

			root.Should().Be(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			yield return new object[]
			{
				new TreeNode<int>(5)
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
				},
				new TreeNode<int>(21)
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
				}
			};
		}
	}
}