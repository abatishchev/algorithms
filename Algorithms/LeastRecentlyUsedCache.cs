using System.Collections.Generic;

namespace Algorithms
{
	public class LeastRecentlyUsedCache<T>
	{
		private readonly LinkedList<T> _list = new LinkedList<T>();

		private readonly int _capacity;

		private int _count;

		public LeastRecentlyUsedCache(int capacity)
		{
			_capacity = capacity;
		}

		public void Add(T item)
		{
			if (_count == _capacity)
			{
				_list.RemoveFirst();
			}

			_list.AddLast(item);
			_count++;

		}

		public void Remove(T item)
		{
			_list.Remove(item);
		}

		public T this[T item]
		{
			get
			{
				var node = _list.Find(item);
				_list.Remove(node);
				Add(item);
				return item;
			}
		}

		public bool Contains(T item)
		{
			return _list.Contains(item);
		}

		public int Count
		{
			get
			{
				return _list.Count;
			}
		}

		public T Newest
		{
			get { return _list.Last.Value; }
		}

		public T Oldest
		{
			get { return _list.First.Value; }
		}
	}
}