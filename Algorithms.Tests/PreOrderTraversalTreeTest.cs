

using System.Collections.Generic;

using Xunit;
using Xunit.Extensions;

namespace Algorithms.Tests
{
	public class PreOrderTraversalTreeTest : PreOrderTraversalTree
	{
		[Theory, PropertyData("GetData")]
		public void PreOrderTraversalTree(TreeNode node, string expected)
		{
			string actual = Do(node);

			Assert.Equal(actual, expected);
		}

		public static IEnumerable<object[]> GetData
		{
			get
			{
				yield return new object[] { CreateTreeNode.Do("ABCD"), "ABDC" };
			}
		}
	}
}