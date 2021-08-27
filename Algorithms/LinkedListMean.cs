namespace Algorithms
{
	public class LinkedListMean
	{
		public static LinkedNode Do1(LinkedNode root)
		{
			LinkedNode slow = root, fast = root;

			while (fast != null && fast.Next != null)
			{
				slow = slow.Next;
				fast = fast.Next.Next;
			}

			return slow;
		}
	}
}
