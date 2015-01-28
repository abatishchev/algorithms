using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
	public class InOrderTraversalTreeTest : InOrderTraversalTree
	{
		[Theory, MemberData("GetData")]
		public void InOrderTraversalTree(TreeNode node, string expected)
		{
			string actual = Do(node);

			Assert.Equal(actual, expected);
		}

		public static IEnumerable<object[]> GetData
		{
			get
			{
				yield return new object[] { CreateTreeNode.Do("ABCD"), "DBAC" };
			}
		}
	}
}