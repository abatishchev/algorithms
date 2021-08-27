namespace Algorithms
{
	public class SwapLinkedList
	{
		public LinkedNode<int> SwapEven(LinkedNode<int> root)
		{
			LinkedNode<int> cur = root;
			int i = 0;

			while (cur != null &&
				cur.Next != null &&
				cur.Next.Next != null &&
				cur.Next.Next.Next != null)
			{
				i++;

				if (i >= 1 && i % 2 != 0)
				{
					Swap(cur, cur.Next, cur.Next.Next, cur.Next.Next.Next);
				}

				cur = cur.Next;
			}

			return root;
		}

		private static void Swap(LinkedNode<int> a, LinkedNode<int> b, LinkedNode<int> c, LinkedNode<int> d)
		{
			// a->b->c->d
			// a->d->c->b

			var e = d.Next;

			a.Next = d;
			d.Next = c;
			c.Next = b;
			b.Next = e;
		}
	}
}