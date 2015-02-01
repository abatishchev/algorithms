namespace Algorithms
{
	public class ReverseLinkedList
	{
		public static LinkedNode Do1(LinkedNode root)
		{
			return Do1(root, null);
		}

		public static LinkedNode Do1(LinkedNode current, LinkedNode prev)
		{
			if (current == null)
				return null;

			LinkedNode n = current.Next;
			current.Next = prev;
			if (n == null)
				return current;

			return Do1(n, current);
		}

		public static LinkedNode Do2(LinkedNode root)
		{
			LinkedNode prev = null;
			LinkedNode current = root;
			LinkedNode next = current.Next;

			while (next != null)
			{
				//current.Next = prev;
				//prev = current;
				//current = next;


				prev = current;
				current.Next = prev;


				next = current.Next;
			}
			return prev;
		}
	}
}