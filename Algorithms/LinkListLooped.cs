using System.Collections.Generic;

namespace Algorithms
{
	public class LinkListLooped
	{
		public static bool Do1(LinkedNode root)
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

		public static bool Do2(LinkedNode root)
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