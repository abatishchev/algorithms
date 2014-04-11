using System;

namespace Algorithms
{
	public class FindTreeNode
	{
		public static TreeNode Do(TreeNode tree, char value)
		{
			if (tree == null)
				return null;

			if ((char)tree.Value == value)
				return tree;

			var x = Do(tree.Left, value);
			if (x != null)
				return x;

			var y = Do(tree.Right, value);
			if (y != null)
				return y;

			return null;
		}
	}
}