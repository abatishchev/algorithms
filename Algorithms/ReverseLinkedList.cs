namespace Algorithms
{
	public class ReverseLinkedList
	{
		public static Node Do1(Node root)
		{
			return Do1(root, null);
		}

		public static Node Do1(Node current, Node prev)
		{
			if (current == null)
				return null;

			Node n = current.Next;
			current.Next = prev;
			if (n == null)
				return current;

			return Do1(n, current);
		}

		public static Node Do2(Node root)
		{
			Node prev = null;
			Node current = root;
			Node next = current.Next;

			while (next != null)
			{
				current.Next = prev;
				prev = current;
				current = next;
				next = current.Next;
			}
			return prev;
		}
	}
}