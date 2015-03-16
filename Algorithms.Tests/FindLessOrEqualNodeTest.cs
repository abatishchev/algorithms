using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class FindLessOrEqualNodeTest : FindLessOrEqualNode
	{
		[Theory]
		[MemberData("GetData")]
		public void FindLessOrEqualNode(TreeNode<double> root, double value, double expected)
		{
			var actual = FindLessOrEqual(root, value);

			actual.Value.Should().Be(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			var tree = new TreeNode<double>(3)
			{
				Left = new TreeNode<double>(2.2)
				{
					Left = new TreeNode<double>(2.1),
					Right = new TreeNode<double>(2.3)
				},
				Right = new TreeNode<double>(3.5)
			};

			yield return new object[] { tree, 2.4, 2.3 };
			yield return new object[] { tree, 2.2, 2.2 };
			yield return new object[] { tree, 3.6, 3.5 };
		}
	}
}