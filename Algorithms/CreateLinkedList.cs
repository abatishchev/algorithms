namespace Algorithms
{
	public class CreateLinkedList
	{
		public Node Create(int depth)
		{
			return Create(depth, new Node());
		}

		private static Node Create(int depth, Node node)
		{
			if (depth == 0)
				return node;

			var temp = new Node(--depth);
			temp.Next = node;

			return Create(depth, temp);
		}
	}
}