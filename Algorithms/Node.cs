using System;
using System.Diagnostics;

namespace Algorithms
{
	[DebuggerDisplay("{Value}")]
	public class Node
	{
		public Node()
		{
		}

		public Node(object value)
		{
			Value = value.ToString();
		}

		public object Value;

		public Node Next;

		private static Node New(Func<Tuple<bool, object>> func)
		{
			Tuple<bool, object> t;

			Node root = null;
			while ((t = func()).Item1)
			{
				root = new Node
				{
					Value = t.Item2,
					Next = root
				};
			}
			return root;
		}

		public static Node New(bool isLooped)
		{
			int i = 0;

			Node root = New(() => Tuple.Create(i++ <= 5, (object)i));

			root.Next.Next.Next = isLooped ? root : null;

			return root;
		}
	}
}