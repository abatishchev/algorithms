using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class CreateLinkedList
	{
		public static LinkedNode Do(int depth = 5)
		{
			return Create(Enumerable.Range(0, depth));
		}

		public static LinkedNode Do(string data)
		{
			return Create(data.Reverse());
		}

		private static LinkedNode Create<T>(IEnumerable<T> data)
		{
			LinkedNode head = null;

			foreach (T v in data)
			{
				LinkedNode temp = new LinkedNode(v) { Next = head };
				head = temp;
			}

			return head;
		}
	}
}