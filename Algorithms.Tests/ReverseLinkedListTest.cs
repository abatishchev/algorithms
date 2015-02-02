using System;
using Xunit;

namespace Algorithms.Tests
{
	public class ReverseLinkedListTest : ReverseLinkedList
	{
		[Theory]
		[InlineData("BAR", "RAB")]
		[InlineData("AB", "BA")]
		public void ReverseLinkedList(string a, string b)
		{
			foreach (var test in new Func<LinkedNode, LinkedNode>[]
				{
					Do1,
					//Do2
				})
			{

				LinkedNode x = CreateLinkedList.Do(a), y = CreateLinkedList.Do(b);

				x = test(x);
				Assert.Equal(x, y, new NodeEqualityComparer());
			}
		}
	}
}