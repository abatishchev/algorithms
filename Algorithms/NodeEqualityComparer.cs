using System;
using System.Collections.Generic;

namespace Algorithms
{
	public class NodeEqualityComparer : IEqualityComparer<LinkedNode>
	{
		public bool Equals(LinkedNode x, LinkedNode y)
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

		public int GetHashCode(LinkedNode node)
		{
			return node.GetHashCode();
		}
	}
}