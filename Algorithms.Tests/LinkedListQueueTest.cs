using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class LinkedListQueueTest
	{
		[Fact]
		public void CustomQueue()
		{
			var queue = new LinkedListQueue<int>();
			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);

			foreach (var i in new[] { 1, 2, 3 })
			{
				queue.Dequeue().Should().Be(i);
			}
		}
	}
}