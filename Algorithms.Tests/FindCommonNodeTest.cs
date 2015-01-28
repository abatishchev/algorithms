using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
	public class FindCommonNodeTest : FindCommonNode
	{
		[Theory, MemberData("GetData")]
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