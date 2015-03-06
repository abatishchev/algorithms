using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class StackQueue<T> : IQueue<T>
	{
		private readonly Stack<T> _input = new Stack<T>();
		private readonly Stack<T> _output = new Stack<T>();

		public bool Enqueue(T item)
		{
			_input.Push(item);

			return true;
		}

		public T Dequeue()
		{
			if (!_output.Any())
			{
				while (_input.Count != 0)
				{
					_output.Push(_input.Pop());
				}
			}
			if (!_output.Any())
			{
				throw new InvalidOperationException();
			}
			return _output.Pop();
		}
	}
}