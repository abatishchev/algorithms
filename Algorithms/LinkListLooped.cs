using System.Collections.Generic;

namespace Algorithms
{
	public class LinkListLooped1
	{
		public bool IsLooped(LinkedNode root)
		{
			var set = new HashSet<LinkedNode>();

			while (root.Next != null)
			{
				if (!set.Contains(root))
					set.Add(root);
				else
					return true;

				root = root.Next;
			}

			return false;
		}
	}

	public class LinkListLooped2
	{
		public bool IsLooped(LinkedNode root)
		{
			LinkedNode slow = root, fast = root.Next;

			while (fast != null)
			{
				if (slow == fast)
					return true;

				fast = fast.Next.Next;
				slow = slow.Next;
			}

			return false;
		}
	}
}