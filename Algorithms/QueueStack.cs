using System.Collections.Generic;

namespace Algorithms
{
	public class QueueStack<T> : IStack<T>
	{
		private readonly Queue<T> _queue = new Queue<T>();

		public void Push(T item)
		{
			var temp = new Queue<T>();
			while (_queue.Count > 0)
			{
				temp.Enqueue(_queue.Dequeue());
			}

			_queue.Enqueue(item);

			while (temp.Count > 0)
			{
				_queue.Enqueue(temp.Dequeue());
			}
		}

		public T Pop()
		{
			return _queue.Dequeue();
		}
	}
}