using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms
{
	public class Heap<T> : IEnumerable<TreeNode<T>>
	{
		private readonly IList<TreeNode<T>> _nodes = new List<TreeNode<T>>();

		private readonly Func<T, T, bool> _comparer;

		public Heap(Func<T, T, bool> comparer)
		{
			_comparer = comparer;
		}

		public TreeNode<T> Root { get; private set; }

		public void Add(T value)
		{
			Add(new TreeNode<T>(value));
		}

		private void Add(TreeNode<T> node)
		{
			_nodes.Add(node);

			Heapify(_nodes.Count - 1);
		}

		private void Heapify(int pos)
		{
			while (pos > 0)
			{
				int parentPos = (pos - 1) / 2;
				if (_comparer(_nodes[parentPos].Value, _nodes[pos].Value))
				{
					_nodes.Swap(parentPos, pos);
					pos = parentPos;
				}
				else break;
			}
		}

		public IEnumerator<TreeNode<T>> GetEnumerator()
		{
			return _nodes.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public T this[int index]
		{
			get { return _nodes[index].Value; }
		}
	}
}
