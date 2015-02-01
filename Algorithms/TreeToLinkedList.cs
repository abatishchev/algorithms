namespace Algorithms
{
	public class TreeToLinkedList
	{
		private static LinkedNode _root;
		private static LinkedNode _current;

		public static LinkedNode Do(TreeNode node)
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
				_root = new LinkedNode(node.Value);
				_current = _root;
			}
			else
			{
				LinkedNode t = new LinkedNode(node.Value);
				_current.Next = t;
				_current = t;
			}
		}
	}
}