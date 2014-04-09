using System.Collections.Generic;

namespace Algorithms
{
	public class LinkListLooped
	{
		public static bool Do1(Node root)
		{
			var set = new HashSet<Node>();

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

		public static bool Do2(Node root)
		{
			Node slow = root, fast = root.Next;

			while (slow.Next != null && fast.Next != null)
			{
				if (slow == fast)
					return true;

				if (fast == null)
					return false;

				fast = fast.Next.Next;
				slow = slow.Next;
			}

			return false;
		}
	}
}