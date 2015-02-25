namespace Algorithms
{
	public class LinkedListStack<T>
	{
		private LinkedNode<T> _top;

		public void Push(T item)
		{
			if (_top == null)
			{
				_top = new LinkedNode<T>(item);
			}
			else
			{
				_top = new LinkedNode<T>(item) { Next = _top };
			}
		}

		public T Pop()
		{
			var item = _top;
			_top = _top.Next;
			return item.Item;
		}
	}
}