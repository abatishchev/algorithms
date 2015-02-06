using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class FixedSizePriorityQueue
	{
		private readonly int _capacity;

		private List<int> _list = new List<int>();

		public FixedSizePriorityQueue(int capacity)
		{
			_capacity = capacity;
		}

		public bool Enqueue(int item)
		{
			if (_list.Any() && item <= _list.First())
				return false;

			_list.Add(item);

			_list = _list.OrderBy(i => i).ToList();

			if (_list.Count > _capacity)
				_list = _list.Take(_capacity).ToList();

			return true;
		}
	}
}