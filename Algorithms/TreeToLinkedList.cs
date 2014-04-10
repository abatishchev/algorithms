namespace Algorithms
{
	public class TreeToLinkedList
	{
		private static Node root;
		private static Node current;

		public static Node Do(TreeNode node)
		{
			if (node == null)
				return null;

			Do(node.Left);

			Visit(node);

			Do(node.Right);

			return root;
		}

		private static void Visit(TreeNode node)
		{
			if (root == null)
			{
				root = new Node(node.Value);
				current = root;
			}
			else
			{
				Node t = new Node(node.Value);
				current.Next = t;
				current = t;
			}
		}
	}
}