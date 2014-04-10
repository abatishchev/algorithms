using System;
using System.Collections.Generic;

namespace Algorithms
{
	public class NodeEqualityComparer : IEqualityComparer<Node>
	{
		public bool Equals(Node x, Node y)
		{
			while (true)
			{
				if (x == null && y == null)
					return true;

				if (x == null || y == null)
					return false;

				if (!String.Equals(x.Value.ToString(), y.Value.ToString()))
					return false;

				x = x.Next;
				y = y.Next;

				if (x == null && y == null)
					return true;
			}
		}

		public int GetHashCode(Node node)
		{
			return node.GetHashCode();
		}
	}
}