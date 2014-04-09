using System.Collections.Generic;

namespace Algorithms
{
	public class NodeEqualityComparer : IEqualityComparer<Node>
	{
		public bool Equals(Node x, Node y)
		{
			if (x == null || y == null)
				return false;

			while (true)
			{
				if (x.Value != y.Value)
					return false;

				x = x.Next;
				y = y.Next;

				if (x == null && y == null)
					return true;
			}
		}

		public int GetHashCode(Node node)
		{
			int hashCode = 0;
			while (node.Next != null)
			{
				hashCode ^= node.Value.GetHashCode();
			}
			return hashCode;
		}
	}
}