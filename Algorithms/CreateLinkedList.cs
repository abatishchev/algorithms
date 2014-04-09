using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class CreateLinkedList
	{
		public static Node Do(int depth = 5)
		{
			return Create(Enumerable.Range(0, depth), new Node());
		}

		public static Node Do(string data)
		{
			return Create(data.Reverse(), new Node());
		}

		private static Node Create<T>(IEnumerable<T> data, Node node)
		{
			if (!data.Any())
				return node;

			var current = new Node(data.First());
			current.Next = node;

			return Create(data.Skip(1), current);
		}
	}
}