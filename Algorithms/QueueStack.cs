using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class QueueStack<T> : IStack<T>
	{
		private readonly Queue<T> _queue = new Queue<T>();

		public void Push(T item)
		{
			var temp = new Queue<T>();

			FromQueue(_queue, temp);

			_queue.Enqueue(item);

			FromQueue(temp, _queue);
		}

		private static void FromQueue(Queue<T> source, Queue<T> target)
		{
			while (source.Any())
			{
				target.Enqueue(source.Dequeue());
			}
		}

		public T Pop()
		{
			return _queue.Dequeue();
		}
	}
}