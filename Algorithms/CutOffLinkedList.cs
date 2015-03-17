namespace Algorithms
{
	public class CutOffLinkedList
	{
		public void CutOff(ref LinkedNode<int> head, ref LinkedNode<int> tail, int h, int t)
		{
			int i = -1;
			LinkedNode<int> cur = head.Next;
			tail = head;
			while (cur != null)
			{
				i++;
				if (i == t - 1)
				{
					head = cur;
				}
				if (i > t - 1)
				{
					tail = tail.Next;
				}

				cur = cur.Next;
			}
		}
	}
}