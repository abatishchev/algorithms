using Xunit;

namespace Algorithms.Tests
{
	public class CreateLinkedListTest : CreateLinkedList
	{
		[Theory]
		[InlineData(1)]
		[InlineData(10)]
		public void CreateLinkedList(int depth)
		{
			LinkedNode root = Do(depth);

			int i = 0;
			do
			{
				i++;
			} while ((root = root.Next) != null);

			Assert.Equal(i, depth);
		}
	}
}