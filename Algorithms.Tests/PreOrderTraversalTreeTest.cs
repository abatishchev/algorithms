using Xunit;

namespace Algorithms.Tests
{
	public class PreOrderTraversalTreeTest : PreOrderTraversalTree
	{
		[Theory]
		[InlineData("ABCD", "ABDC")]
		public void PreOrderTraversalTree(string data, string expected)
		{
			var root = CreateTreeNode.Do(data);

			string actual = Do(root);

			Assert.Equal(actual, expected);
		}
	}
}