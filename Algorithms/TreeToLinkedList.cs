namespace Algorithms
{
	public class TreeToLinkedList
	{
		private static Node _root;
		private static Node _current;

		public static Node Do(TreeNode node)
		{
			if (node == null)
				return null;

			Do(node.Left);

			Visit(node);

			Do(node.Right);

			return _root;
		}

		private static void Visit(TreeNode node)
		{
			if (_root == null)
			{
				_root = new Node(node.Value);
				_current = _root;
			}
			else
			{
				Node t = new Node(node.Value);
				_current.Next = t;
				_current = t;
			}
		}
	}
}