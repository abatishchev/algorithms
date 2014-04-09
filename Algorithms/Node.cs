using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
	[DebuggerDisplay("{ToString()}")]
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

		public override string ToString()
		{
			if (LinkListLooped.Do1(this))
				return Value.ToString();

			return String.Join("->", ToString(this));
		}

		private static IEnumerable<object> ToString(Node node)
		{
			while (node != null)
			{
				yield return node.Value;
				node = node.Next;
			}
		}
	}
}