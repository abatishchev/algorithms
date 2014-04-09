namespace Algorithms
{
	public class LinkedListMean
	{
		public Node Do(Node root)
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
