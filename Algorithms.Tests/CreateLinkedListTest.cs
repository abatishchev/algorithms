using Xunit;

namespace Algorithms.Tests
{
	public class CreateLinkedListTest : CreateLinkedList
	{
		[Fact]
		public void CreateLinkedList()
		{
			int count = 5;

			Node root = Create(count);

			int i = 0;
			while ((root = root.Next) != null)
			{
				i++;
			}

			Assert.Equal(i, count);
		}
	}
}