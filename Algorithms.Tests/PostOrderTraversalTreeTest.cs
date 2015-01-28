using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
	public class PostOrderTraversalTreeTest : PostOrderTraversalTree
	{
		[Theory, MemberData("GetData")]
		public void PostOrderTraversalTree(TreeNode node, string expected)
		{
			string actual = Do(node);

			Assert.Equal(actual, expected);
		}

		public static IEnumerable<object[]> GetData
		{
			get
			{
				yield return new object[] { CreateTreeNode.Do("ABCD"), "DBCA" };
			}
		}
	}
}