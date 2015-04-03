using System.Collections.Generic;

namespace Algorithms
{
	public class CloneLinkedList
	{
		public LinkedNode<int> Clone(LinkedNode<int> root)
		{
			LinkedNode<int> cur = root, n = new LinkedNode<int>(cur.Value), r = n;

			var no = new List<int?>();
			var nodes = new List<LinkedNode<int>>();

			while (cur != null)
			{
				n.Value = cur.Value;
				n.Next = cur.Next != null ? new LinkedNode<int>(-1) : null;

				no.Add(cur.Other != null ? cur.Other.Value : (int?)null);
				nodes.Add(n);

				n = n.Next;
				cur = cur.Next;
			}

			cur = r;

			int i = 0;
			while (cur != null)
			{
				var ov = no[i++];
				cur.Other = ov.HasValue ? nodes[ov.Value - 1] : null;

				cur = cur.Next;
			}

			return r;
		}
	}
}