using System.Collections.Generic;

using Xunit;
using Xunit.Extensions;

namespace Algorithms.Tests
{
	public class FindCommonNodeTest : FindCommonNode
	{
		[Theory, PropertyData("GetData")]
		public void FindCommonNode(TreeNode x, TreeNode y, char expected)
		{
			TreeNode actual = Do(x, y);

			Assert.Equal((char)actual.Value, expected);
		}

		public static IEnumerable<object[]> GetData
		{
			get
			{
				TreeNode tree = CreateTreeNode.Do("ABCDEFG");
				yield return new object[] { FindTreeNode.Do(tree, 'F'), FindTreeNode.Do(tree, 'C'), 'A' };
			}
		}
	}
}