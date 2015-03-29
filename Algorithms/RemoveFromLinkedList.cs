namespace Algorithms
{
	public class RemoveFromLinkedList
	{
		public LinkedNode<int> Remove(LinkedNode<int> head, int n)
		{
			if (n == 1)
			{
				var newHead = head.Next;

				while (head.Next != null)
				{
					head = head.Next;
				}

				head.Next = null;

				return newHead;
			}
			else
			{
				int i = 0;

				var cur = head;
				while (++i < n - 1)
				{
					cur = cur.Next;
				}

				var t = cur;
				var slow = head;

				while (cur.Next.Next.Next != null)
				{
					slow = slow.Next;
					cur = cur.Next;
				}

				t.Next = t.Next.Next;
				slow.Next = slow.Next.Next;
			}

			return head;
		}
	}
}