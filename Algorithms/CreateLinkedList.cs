using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class CreateLinkedList
	{
		public static Node Do(int depth = 5)
		{
			return Create(Enumerable.Range(0, depth));
		}

		public static Node Do(string data)
		{
			return Create(data.Reverse());
		}

		private static Node Create<T>(IEnumerable<T> data)
		{
			Node head = null;

			foreach (T v in data)
			{
				Node temp = new Node(v) { Next = head };
				head = temp;
			}

			return head;
		}
	}
}