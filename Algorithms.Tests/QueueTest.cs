using System;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class QueueTest
	{
		[Theory]
		[InlineData(typeof(StackQueue<int>))]
		[InlineData(typeof(LinkedListQueue<int>))]
		public void Queue(Type t)
		{
			IQueue<int> queue = (IQueue<int>)Activator.CreateInstance(t);
			queue.Enqueue(1);

			queue.Dequeue().Should().Be(1);

			queue.Enqueue(2);
			queue.Enqueue(3);

			queue.Dequeue().Should().Be(2);

			queue.Enqueue(4);
			queue.Enqueue(5);

			foreach (var i in new[] { 3, 4, 5 })
			{
				queue.Dequeue().Should().Be(i);
			}
		}
	}
}