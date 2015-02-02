using Xunit;

namespace Algorithms.Tests
{
	public class FindCommonNodeTest : FindCommonNode
	{
		[Theory]
		[InlineData("ABCDEFG", 'F', 'C', 'A')]
		public void FindCommonNode(string data, char x, char y, char expected)
		{
			TreeNode root = CreateTreeNode.Do(data);

			TreeNode xr = FindTreeNode.Do(root, x), xy = FindTreeNode.Do(root, y);

			TreeNode actual = Do(xr, xy);

			Assert.Equal((char)actual.Value, expected);
		}
	}
}