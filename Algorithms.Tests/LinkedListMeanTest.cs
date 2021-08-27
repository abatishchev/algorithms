using Xunit;

namespace Algorithms.Tests
{
	public class LinkedListMeanTest : LinkedListMean
	{
		[Theory]
		[InlineData("BAR", "A")]
		public void LinkedListMean(string data, string expected)
		{
			var root = CreateLinkedList.Do(data);

			LinkedNode actual = Do1(root);

			Assert.Equal(actual.Value, expected);
		}
	}
}