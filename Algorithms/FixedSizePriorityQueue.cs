using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class FixedSizePriorityQueue : IQueue<int>, IEnumerable<int>
	{
		private readonly int _capacity;
		private readonly Func<int, int, bool> _comparer;

		private List<int> _list = new List<int>();

		public FixedSizePriorityQueue(int capacity, Func<int, int, bool> comparer)
		{
			_capacity = capacity;
			_comparer = comparer;
		}

		public bool Enqueue(int item)
		{
			if (_list.Count < _capacity)
			{
				_list.Add(item);

				_list = _list.OrderBy(i => i).ToList();

				return true;
			}

			if (!_comparer(item, _list.Last()))
				return false;

			_list.Add(item);

			_list = _list.OrderBy(i => i).ToList();

			if (_list.Count > _capacity)
				_list = _list.Take(_capacity).ToList();

			return true;
		}

		public int Dequeue()
		{
			return _list.FirstOrDefault();
		}

		public IEnumerator<int> GetEnumerator()
		{
			return _list.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}