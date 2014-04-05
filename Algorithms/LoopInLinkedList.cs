using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
	[DebuggerDisplay("{Value}")]
	public class Node
	{
		private static int Total;

		public Node()
		{
			Value = ++Total;
		}

		public Node Next;

		public int Value;

		public static Node New(bool isLooped)
		{
			Total = 0;

			Node root = new Node
			{
				Next = new Node
				{
					Next = new Node()
				}
			};

			root.Next.Next.Next = isLooped ? root : null;

			return root;
		}
	}

	public class LoopInLinkedList
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

			while (slow.Next != null)
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