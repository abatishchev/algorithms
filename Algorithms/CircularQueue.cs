using System;

namespace Algorithms
{
	public class CircularQueue
	{
		private readonly int[] _items;

		private int _head, _tail;

		private readonly object _readLock = new object(), _writeLock = new object();

		protected CircularQueue()
		{
		}

		private CircularQueue(int capacity)
		{
			if (capacity <= 0)
				throw new ArgumentOutOfRangeException("capacity", "Capacity can't be equal or less than 0");

			_items = new int[capacity];

			_head = -1;
			_tail = -1;
		}

		public static CircularQueue Init(int capacity)
		{
			return new CircularQueue(capacity);
		}

		public void Enqueue(int item)
		{
			lock (_writeLock)
			{
				if ((_head == 0 && _tail == _items.Length - 1) || (_tail + 1 == _head))
				{
					throw new InvalidOperationException("Queue is full");
				}

				if (_tail == _items.Length - 1)
				{
					_tail = 0;
				}
				else
				{
					_tail++;
				}

				_items[_tail] = item;

				if (_head == -1)
				{
					_head = 0;
				}
			}
		}

		public int Dequeue()
		{
			lock (_readLock)
			{
				if (_head == -1)
				{
					throw new InvalidOperationException("Queue is empty");
				}

				int item = _items[_head];

				_items[_head] = -1;

				if (_head == _tail)
				{
					_head = -1;
					_tail = -1;
				}
				else if (_head == _items.Length - 1)
				{
					_head = 0;
				}
				else
				{
					_head++;
				}
				return item;
			}
		}
	}
}