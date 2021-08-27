using Xunit;

namespace Algorithms.Tests
{
	public class InOrderTraversalTreeTest : InOrderTraversalTree
	{
		[Theory]
		[InlineData("ABCD", "DBAC")]
		public void InOrderTraversalTree(string data, string expected)
		{
			var root = CreateTreeNode.Do(data);

			string actual = Do(root);

			Assert.Equal(actual, expected);
		}
	}
}