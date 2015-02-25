namespace Algorithms
{
	public class LinkedListQueue<T> : IQueue<T>
	{
		private LinkedNode<T> _tail;
		private LinkedNode<T> _head;

		public void Enqueue(T item)
		{
			var node = new LinkedNode<T>(item);

			if (_head == null && _tail == null)
			{
				_head = node;
				_tail = node;
			}
			else
			{
				_tail.Next = node;
				_tail = _tail.Next;
			}
		}

		public T Dequeue()
		{
			var node = _head;
			_head = _head.Next;
			return node.Item;
		}
	}
}