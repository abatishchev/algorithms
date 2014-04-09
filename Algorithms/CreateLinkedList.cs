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
			var node = new Node(data.FirstOrDefault());
			Create(data.Skip(1), node);
			return node;
		}

		private static void Create<T>(IEnumerable<T> data, Node node)
		{
			if (!data.Any())
				return;

			T value = data.First();

			Node t = new Node(value);

			node.Next = t;

			Create(data.Skip(1), node.Next);
		}
	}
}