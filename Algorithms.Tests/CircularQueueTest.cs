using System;
using Xunit;

namespace Algorithms.Tests
{
	public class CircularQueueTest : CircularQueue
	{
		[Fact]
		public void Enqueue_should_add_new_items_to_queue()
		{
			var queue = CircularQueue.Init(5);

			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);
			queue.Enqueue(4);

			AssertQueue(queue, 1, 2, 3, 4);
		}

		[Fact]
		public void Enqueue_should_add_new_items_after_Dequeue()
		{
			var queue = CircularQueue.Init(5);

			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);
			queue.Enqueue(4);
			queue.Enqueue(5);

			// queue reached full state

			AssertQueue(queue, 1, 2, 3, 4, 5);

			// queue reached empty state

			queue.Enqueue(6);
			queue.Enqueue(7);

			AssertQueue(queue, 6, 7);
		}

		[Fact]
		public void Enqueue_should_throw_exception_when_queue_is_full()
		{
			var queue = CircularQueue.Init(5);

			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);
			queue.Enqueue(4);
			queue.Enqueue(5);

			// queue reached full state

			Action action = () => queue.Enqueue(6);
			Assert.Throws<InvalidOperationException>(action);

			// queue is not corrupted by exception

			AssertQueue(queue, 1, 2, 3, 4, 5);

			// queue reached empty state

			queue.Enqueue(7);
			queue.Enqueue(8);

			AssertQueue(queue, 7, 8);
		}

		[Fact]
		public void Dequeue_should_throw_exception_when_queue_is_empty()
		{
			var queue = CircularQueue.Init(5);

			Action action = () => queue.Dequeue();
			Assert.Throws<InvalidOperationException>(action);

			// queue is not corrupted by exception

			queue.Enqueue(1);
			queue.Enqueue(2);

			AssertQueue(queue, 1, 2);
		}

		private static void AssertQueue(CircularQueue queue, params int[] expected)
		{
			foreach (int e in expected)
			{
				Assert.Equal(queue.Dequeue(), e);
			}
		}
	}
}