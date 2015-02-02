using Xunit;

namespace Algorithms.Tests
{
	public class TreeToLinkedListTest : TreeToLinkedList
	{
		[Theory]
		[InlineData("ABCDEF", "FDBEAC")]
		public void TreeToLinkedList(string data, string expected)
		{
			var root = CreateTreeNode.Do(data);

			LinkedNode list = Do(root);

			string actual = list.ToString(false, "");

			Assert.Equal(actual, expected);
		}
	}
}