using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
	[DebuggerDisplay("{ToString()}")]
	public class LinkedNode
	{
		public LinkedNode()
		{
		}

		public LinkedNode(object value)
		{
			Value = value.ToString();
		}

		public object Value;

		public LinkedNode Next;

		public override string ToString()
		{
			return ToString(true, "->");
		}

		public string ToString(bool safe, string sep)
		{
			return safe ?
				(Value ?? new object()).ToString() :
				String.Join(sep, GetValues(this));
		}

		private static IEnumerable<object> GetValues(LinkedNode node)
		{
			while (node != null)
			{
				yield return node.Value;
				node = node.Next;
			}
		}
	}
}