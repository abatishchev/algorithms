namespace Algorithms
{
	public class LinkedListMean
	{
		public static Node Do1(Node root)
		{
			Node slow = root, fast = root;

			while (fast != null && fast.Next != null)
			{
				slow = slow.Next;
				fast = fast.Next.Next;
			}

			return slow;
		}
	}
}
