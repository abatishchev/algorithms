using System;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class QueueTest
	{
		[Theory]
		[InlineData(typeof(LinkedListQueue<int>))]
		[InlineData(typeof(StackQueue<int>))]
		public void CustomQueue(Type t)
		{
			IQueue<int> queue = (IQueue<int>)Activator.CreateInstance(t);
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