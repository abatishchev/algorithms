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

			TreeNode xr = FindTreeNode.Find(root, x), xy = FindTreeNode.Find(root, y);

			TreeNode actual = Find(xr, xy);

			Assert.Equal((char)actual.Value, expected);
		}
	}
}