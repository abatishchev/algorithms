using Xunit;

namespace Algorithms.Tests
{
	public class PostOrderTraversalTreeTest : PostOrderTraversalTree
	{
		[Theory]
		[InlineData("ABCD", "DBCA")]
		public void PostOrderTraversalTree(string data, string expected)
		{
			var root = CreateTreeNode.Do(data);

			string actual = Do(root);

			Assert.Equal(actual, expected);
		}
	}
}