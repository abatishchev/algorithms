using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class LinkedListStackTest
	{
		[Fact]
		public void CustomQueue()
		{
			var queue = new LinkedListStack<int>();
			queue.Push(1);
			queue.Push(2);
			queue.Push(3);

			foreach (var i in new[] { 3, 2, 1 })
			{
				queue.Pop().Should().Be(i);
			}
		}
	}
}