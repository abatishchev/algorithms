namespace Algorithms
{
	public class FindTreeNode
	{
		public static TreeNode Find(TreeNode tree, char value)
		{
			if (tree == null)
				return null;

			if ((char)tree.Value == value)
				return tree;

			var x = Find(tree.Left, value);
			if (x != null)
				return x;

			var y = Find(tree.Right, value);
			return y;
		}
	}
}