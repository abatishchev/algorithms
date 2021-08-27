namespace Algorithms
{
	public class LinkedListQueue<T> : IQueue<T>
	{
		private LinkedNode<T> _tail;
		private LinkedNode<T> _head;

		public bool Enqueue(T item)
		{
			var node = new LinkedNode<T>(item);

			if (_head != null && _tail != null)
			{
				_tail.Next = null;
				node.Next = _tail;
				_tail = node;

				var x = _head;
				while (x != null)
				{
					if (x.Next == null)
					{
						x.Next = node;
						break;
					}
					else
					{
						x = x.Next;
					}
				}
			}
			else
			{
				_head = node;
				_head.Next = _tail;

				_tail = node;
			}

			return true;
		}

		public T Dequeue()
		{
			if (_tail != _head)
			{
				var node = _head;
				_head = _head.Next;
				return node.Value;
			}
			else
			{
				var node = _tail;
				_tail = null;
				_head = null;
				return node.Value;
			}
		}
	}
}