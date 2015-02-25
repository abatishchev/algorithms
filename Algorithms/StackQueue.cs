using System.Collections.Generic;

namespace Algorithms
{
	public class StackQueue<T> : IQueue<T>
	{
		private readonly Stack<T> _input = new Stack<T>();
		private readonly Stack<T> _output = new Stack<T>();

		public void Enqueue(T item)
		{
			_input.Push(item);
		}

		public T Dequeue()
		{
			if (_output.Count == 0)
			{
				while (_input.Count != 0)
				{
					_output.Push(_input.Pop());
				}
			}
			if (_output.Count != 0)
			{
				return _output.Pop();
			}
			return default(T);
		}
	}
}